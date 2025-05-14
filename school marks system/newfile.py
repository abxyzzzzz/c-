def fibonacci_until_sum_exceeds(limit: int) -> list:
    if limit < 0:
        return []  # Negative input ke liye empty list return karega
    elif limit == 0:
        return [0]  # Agar input 0 hai, to sirf 0 return karega

    fib_series = []
    a, b = 0, 1
    
    while a <= limit:
        fib_series.append(a)
        a, b = b, a + b
    
    return fib_series

n = int(input("Give me Number "))
result = fibonacci_until_sum_exceeds(n)
print(", ".join(map(str, result)))