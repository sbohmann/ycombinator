local function fibonacci(n)
    local function makeF(f)
        return function(x,u,s)
            if x < 2 then
                return u+s
            else
                return f(x-1, u+s, u)
            end
        end
    end

    local function y(y)
        return makeF(function(...)
            return y(y)(...)
        end)
    end

    return y(y)(n-1, 1, 0)
end

for i = 1, 15 do
    print(i, '->', fibonacci(i))
end

-- assert(fibonacci(0) ==  0)
assert(fibonacci(1) ==  1)
assert(fibonacci(2) ==  1)
assert(fibonacci(3) ==  2)
assert(fibonacci(4) ==  3)
assert(fibonacci(5) ==  5)
assert(fibonacci(6) ==  8)
assert(fibonacci(7) == 13)

return fibonacci
