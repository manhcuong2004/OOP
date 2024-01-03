def fibonacci(n):
    if n <= 0:
        return []
    elif n == 1:
        return [0]
    elif n == 2:
        return [0, 1]
    else:
        fib_series = [0, 1]
        while len(fib_series) < n:
            next_number = fib_series[-1] + fib_series[-2]
            fib_series.append(next_number)
        return fib_series

n = int(input("Nhap so luong so Fibonacci muon tinh: "))

if n <= 0:
    print("Vui long nhap mot so nguyen duong.")
else:
    fib_series = fibonacci(n)
    print(f"Day Fibonacci gom {n} so la: {fib_series}")
