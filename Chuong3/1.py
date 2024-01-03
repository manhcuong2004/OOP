def tinh_tong(n):
    if n == 1:
        return 1
    else:
        return n + tinh_tong(n-1)

n = int(input("Nhap gia tri n: "))
if n <= 0:
    print("Vui long nhap mot so nguyen duong.")
else:
    ket_qua = tinh_tong(n)
    print(f"Tong cua day so tu 1 den {n} la {ket_qua}.")
def tinh_tong(n):
    if n == 1:
        return 1
    else:
        return n + tinh_tong(n-1)

n = int(input("Nhap gia tri n: "))
if n <= 0:
    print("Vui long nhap mot so nguyen duong.")
else:
    ket_qua = tinh_tong(n)
    print(f"Tong cua day so tu 1 den {n} la {ket_qua}.")
