def cong_chu_so(n):
    while n >= 10:
        n = sum(int(digit) for digit in str(n))
    return n

so = int(input("Nhập số bất kì: "))
ket_qua = cong_chu_so(so)
print(f"Kết quả: {ket_qua}")
