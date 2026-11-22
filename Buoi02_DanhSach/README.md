# Buổi 02 – Danh sách

Họ tên: Phạm Đức Huy · MSV: 10125164 · Lớp: 10125O.1

## Bài đã làm
- Chương 4: Mảng và Danh sách liên kết - Bài 1, 2, 3, 4, 5

## Cách chạy
```
dotnet run --project Buoi01_DeQuy
```

## Kết quả chạy
```
=============== Chương 4: Mảng và danh sách liên kết ===============
----------Bài 1----------
Nhập số phần tử trong mảng: 5
Nhập số nguyên thứ 1: 6
Nhập số nguyên thứ 2: 7
Nhập số nguyên thứ 3: 8
Nhập số nguyên thứ 4: 9
Nhập số nguyên thứ 5: 10
Danh sách các phần tử trong mảng: 6 7 8 9 10
Nhập giá trị x cần chèn: 2
Nhập vị trí k cần chèn vào: 3
Mảng sau khi chèn 2 vào vị trí 3: 6 7 8 2 9 10

----------Bài 2----------
Nhập số nhân viên cần cho vào DS: 3

---Nhập thông tin cho nhân viên thứ 1---
Nhập mã nhân viên: NV01
Nhập họ tên nhân viên: Nguyễn Văn A
Nhập năm sinh: 2009
Nhập phòng ban: CNTT
Nhập lương cơ bản: 3000000
Nhập lương thưởng: 300000

---Nhập thông tin cho nhân viên thứ 2---
Nhập mã nhân viên: NV02
Nhập họ tên nhân viên: Phạm Thị B
Nhập năm sinh: 2008
Nhập phòng ban: KHMT
Nhập lương cơ bản: 3000000
Nhập lương thưởng: 200000

---Nhập thông tin cho nhân viên thứ 3---
Nhập mã nhân viên: NV03
Nhập họ tên nhân viên: Trần Văn C
Nhập năm sinh: 2007
Nhập phòng ban: LTW
Nhập lương cơ bản: 2000000
Nhập lương thưởng: 100000

==========DANH SÁCH NHÂN VIÊN==========
Nhân viên thứ 1:
     - Mã nhân viên: NV01
     - Tên nhân viên: Nguyễn Văn A
     - Năm sinh: 2009
     - Phòng ban NV: CNTT
     - Lương cơ bản: 3000000
     - Lương thưởng: 300000
     - Tổng thực lĩnh tháng: 0

Nhân viên thứ 2:
     - Mã nhân viên: NV02
     - Tên nhân viên: Phạm Thị B
     - Năm sinh: 2008
     - Phòng ban NV: KHMT
     - Lương cơ bản: 3000000
     - Lương thưởng: 200000
     - Tổng thực lĩnh tháng: 3300000

Nhân viên thứ 3:
     - Mã nhân viên: NV03
     - Tên nhân viên: Trần Văn C
     - Năm sinh: 2007
     - Phòng ban NV: LTW
     - Lương cơ bản: 2000000
     - Lương thưởng: 100000
     - Tổng thực lĩnh tháng: 6500000

Danh sách nhân viên có lương cơ bản thấp nhất
- Mã nhân viên: NV03 | Họ tên: Trần Văn C | Lương cơ bản: 2000000

Số lượng nhân viên có lương thưởng >= 1200000: 0
Danh sách nhân viên sau khi sắp xếp:
- Mã nhân viên: NV03 | Họ tên: Trần Văn C
- Mã nhân viên: NV02 | Họ tên: Phạm Thị B
- Mã nhân viên: NV01 | Họ tên: Nguyễn Văn A

Danh sách nhân viên khi tăng lương lên 5%:
- Mã nhân viên: NV03 | Lương cơ bản: 2100000
- Mã nhân viên: NV02 | Lương cơ bản: 3150000
- Mã nhân viên: NV01 | Lương cơ bản: 3150000

----------Bài 3----------
Nhập ma trận n (0 <= n < 100): 3
a[0,0] = 4
a[0,1] = 5
a[0,2] = 6
a[1,0] = 7
a[1,1] = 8
a[1,2] = 9
a[2,0] = 3
a[2,1] = 2
a[2,2] = 1

a. Tổng tất cả phần tử của ma trận: 45
b. Giá trị dương nhỏ nhất: 1
c. Tổng các phần tử trên đường chéo phụ: 17
d. Đường chéo chính KHÔNG tăng dần.

----------Bài 4----------
Nhập số lượng phần tử: 3
Nhập phần tử thứ 1 (số nguyên dương): 7
Nhập phần tử thứ 2 (số nguyên dương): 8
Nhập phần tử thứ 3 (số nguyên dương): 9

Danh sách ban đầu: 7 -> 8 -> 9

Nhập giá trị x cần đếm: 2
a. Số lượng phần tử bằng 2: 0
b. Phần tử dương nhỏ nhất: 7

Nhập giá trị x cần xóa (lần xuất hiện đầu tiên): 8
c. Đã xóa 8. Danh sách sau khi xóa: 7 -> 9

----------Bài 5----------
Nhập số lượng phần tử: 5
Nhập phần tử thứ 1: 8
Nhập phần tử thứ 2: 5
Nhập phần tử thứ 3: 2
Nhập phần tử thứ 4: 5
Nhập phần tử thứ 5: 6
a. Phần tử lớn nhất là: 8
b. Tổng các phần tử là: 26
c. Số lượng số nguyên tố là: 3
d. Số âm: 0, Số bằng 0: 0, Số dương: 5
Nhập giá trị x cần đếm: 4
e. Số lượng phần tử bằng 4 là: 0
f. Phần tử dương nhỏ nhất là: 2