QLSV= DSSinhVien()
ToDo=1
while ToDo!=0:
    print('\n   *************************************************************')
    print('   *                            * M E N U *                            *')
    print('   *   1. Them sinh vien                         *')
    print('   *   2. Xoa sinh vien                           *')
    print('   *   3. Sua sinh vien                           *')
    print('   *   4. Xem danh sach sinh vien                 *')
    print('   *   5. Tinh diem trung binh cho tung sinh vien  *')
    print('   *   6. Tinh diem trung binh mon1, mon2 cua toan bo sinh vien *')
    print('   *   8. In thong tin sinh vien co diem trung binh cao nhat*')
    print('   *   9. In thong tin sinh vien co diem trung binh thap nhat *')
    print('   *   10. Sap xep danh sach sinh vien theo lop va diem trung binh *')
    print('   *   11. Xep loai hoc luc cho tung sinh vien *')
    print('   *   0. Thoat khoi chuong trinh  *')
    print('>>>',end=' ')
    ToDo=int(input(“xin mời chọn chức năng”))
    if ToDo==0:   break
    elif ToDo==1:   QLSV.ThemSinhVien()
        print("Da them 1 sinh vien.")
    elif ToDo==2: print("Nhap ma sinh vien cua SV muon xoa: ",end='')
        maSV=input()
        QLSV.XoaSinhVien(maSV)
    elif ToDo==3:  print("Nhap ma sinh vien cua SV muon sua thong tin: ",end='')
        maSV=input()
        QLSV.CapnhatSinhVien(maSV)
    elif ToDo==4:
        print("Danh sach sinh vien:\n")
        QLSV.inDSSinhVien()
    elif ToDo==5: QLSV.tinhTBSV()  
        print("Diem trung binh cua toan bo sinh vien da duoc tinh.")
    elif ToDo==6:
        print("Diem trung binh mon1, mon2 cua toan bo sinh vien:",QLSV.TBDiem1_2())
    
    elif ToDo==11: QLSV.xepHocLuc()  
        print("Toan bo sinh vien da duoc xep hoc luc.")
    input("\nBam Enter de tiep tuc.")
    
    