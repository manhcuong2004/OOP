
n = len(A)
for i in range(n):
    min_index = i
    for j in range(i + 1, n):
        if A[j] < A[min_index]:
            min_index = j

    A[i], A[min_index] = A[min_index], A[i]

# Ví dụ sử dụng
A = [64, 25, 12, 22, 11]

print(A)
