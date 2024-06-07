create database QLCHDN
go

use QLCHDN;
go


go
create table Account 
(
	username nvarchar(20) primary key, -- tài khoản 
	passwork nvarchar(100), -- mật khẩu
	typeuser nvarchar(2), 
	tthai nvarchar(3)
)

go
create table Loai
(
	maloai nvarchar(10) primary key,
	tenloai nvarchar(15)
)
go
create table Chucvu
(
	macv nvarchar(5) primary key,
	tencv nvarchar(15),
)
go
create table Sanpham
(
	masp nvarchar(10) primary key,
	tensp nvarchar(50),
	soluong int,
	idloai nvarchar(10),
	dvtinh nvarchar(10),
	giamua int,
	giaban int,
	ttrang nvarchar(5),

	foreign key (idloai) references Loai(maloai)
)
go
create table Nhanvien
(
	manv nvarchar(10) primary key,
	tennv nvarchar(50),
	macv nvarchar(5),
	sdt nvarchar(10),
	ngaysinh smalldatetime,
	diachi nvarchar(100),
	tthai nvarchar(3)
	--hsluong float,
	
	foreign key (macv) references Chucvu(macv)
	
)
go
create table Khachhang
(
	makh nvarchar(10) primary key,
	tenkh nvarchar(30),
	sdt nvarchar(10),
	ngaysinh smalldatetime,
	diachi nvarchar(100),
	tthai nvarchar(3),
	congno int,
	tongmua int,
	
)
go
create table Hoadon
(
	mahd int primary key, --- nvc(10)
	manv nvarchar(10),
	makh nvarchar(10),
	ngaygd smalldatetime,
	tonghd int,
	tra int,
	conlai int,
	tthai nvarchar(20),

	foreign key (makh) references Khachhang(makh),
	foreign key (manv) references Nhanvien(manv)
)
go
create table thongtinhoadon
(
	id int primary key identity(1,1),
	loaisp nvarchar(10),
	masp nvarchar(10),
	tensp nvarchar(50),
	dvtinh nvarchar(10),
	giaban int,
	soluong int,
	thanhtien int,
	idhd int,
	foreign key (idhd) references Hoadon(mahd),
	foreign key (masp) references Sanpham(masp),
	foreign key (loaisp) references Loai(maloai)
)
go
create table Nhaphang
(
	id int primary key identity(1,1),
	masp nvarchar(10),
	tensp nvarchar(50),
	soluong int,
	ngaynhap smalldatetime, -- smalldatetime
	manv nvarchar(10),
	dvtinh nvarchar(10),
	giaban int,
	tong int

	foreign key (masp) references Sanpham(masp),
	foreign key (manv) references Nhanvien(manv)
)
go
create table chamcong
(
	id int primary key identity(1, 1),
	manv nvarchar(10),
	ngay smalldatetime,
	ghichu nvarchar(200),

	foreign key (manv)  references Nhanvien(manv)
)
create table lichsu
(
	id int primary key identity(1,1),
	manv nvarchar(10), 
	ngay smalldatetime,
	chitiet nvarchar(200),

	foreign key (manv)  references Nhanvien(manv)
)
go

select * from Account
select * from Loai
select * from Chucvu
select * from Sanpham
select * from Nhanvien
select * from Khachhang
select * from Hoadon
select * from thongtinhoadon
select * from Nhaphang
select * from chamcong
select * from lichsu


insert into Account values ('NV02', '1962026656160185351301320480154111117132155', 'AD', N'Bật');
insert into Account values ('NV01', '1962026656160185351301320480154111117132155', 'NV', N'Bật');
insert into Account values ('NV03', '1962026656160185351301320480154111117132155', 'NV', N'Bật');
insert into Account values ('NV04', '1962026656160185351301320480154111117132155', 'NV', N'Bật');
insert into Account values ('NV05', '1962026656160185351301320480154111117132155', 'NV', N'Bật');
insert into Account values ('NV06', '1962026656160185351301320480154111117132155', 'NV', N'Bật');
insert into Account values ('NV07', '1962026656160185351301320480154111117132155', 'NV', N'Bật');

insert into Chucvu values ('AD', N'Quản Lý');
insert into Chucvu values ('NV', N'Nhân Viên');

insert into nhanvien values ('NV01', N'Giang Thanh Tùng', 'NV', '0338426663', N'2004/8/20', N'Đông Tảo, Khoái Châu, Hưng Yên',N'Bật');
insert into nhanvien values ('NV02', N'Đỗ Anh Tuấn', 'AD', '0963541319', N'2004/9/15', N'Tân Lập, Yên Mỹ, Hưng Yên',N'Bật');
insert into nhanvien values ('NV03', N'Hoàng Văn Tuân', 'NV', '0338428856', N'2004/1/01', N'Bình Minh, Khoái Châu, Hưng Yên',N'Bật');
insert into nhanvien values ('NV04', N'Trần Hà Thanh Tùng', 'NV', '0338889900', N'2004/12/21', N'Thành Phố Hưng Yên',N'Bật');
insert into nhanvien values ('NV05', N'Võ Huy Hoàng', 'NV', '0338889900', N'2003/9/16', N'Đông Tảo, Khoái Châu, Hưng Yên',N'Bật');
insert into nhanvien values ('NV06', N'Đỗ Trọng Lợi', 'NV', '0338889900', N'2004/11/16', N'Đông Tảo, Khoái Châu, Hưng Yên',N'Bật');
insert into nhanvien values ('NV07', N'Nguyễn Hữu Linh', 'NV', '0338889900', N'2004/9/25', N'Đông Tảo, Khoái Châu, Hưng Yên',N'Bật');

-- them khach hang
insert into Khachhang values ('KH00', N'Khách lẻ',N'Trống' , '1990/01/01', N'Trống',N'Tắt', 0, 0);
insert into Khachhang values ('KH01', N'Giang Thanh Tùng','0338642666' , '2004/08/20', N'Đông Tảo, Khoái Châu, Hưng Yên',N'Bật', 0, 0);
insert into Khachhang values ('KH02', N'Hoàng Văn Tuân', '0338642667', '2004/01/01', N'Bình Minh, Khoái Châu, Hưng Yên',N'Bật', 0, 0);
insert into Khachhang values ('KH03', N'Trần Hà Thanh Tùng','0338642668', '2004/12/21', N'Thành Phố Hưng Yên',N'Bật', 0, 0);
insert into Khachhang values ('KH04', N'Võ Huy Hoàng','0338642669', '2003/09/16', N'Đông Tảo, Khoái Châu, Hưng Yên',N'Bật', 0, 0);
insert into Khachhang values ('KH05', N'Đỗ Trọng Lợi','0338642660', '2000/12/12', N'Đông Tảo, Khoái Châu, Hưng Yên',N'Bật', 0, 0);
insert into Khachhang values ('KH06', N'Nguyễn Hữu Linh','0338642660', '2004/09/25', N'Đông Tảo, Khoái Châu, Hưng Yên',N'Bật', 0, 0);



-- Thêm các loại mới liên quan đến điện nước
INSERT INTO Loai VALUES ('BD', N'Bóng Đèn');
INSERT INTO Loai VALUES ('CB', N'Cầu Dao');
INSERT INTO Loai VALUES ('DAU', N'Ổ Cắm Đơn');
INSERT INTO Loai VALUES ('DAO', N'Ổ Cắm Đôi');
INSERT INTO Loai VALUES ('QUAT', N'Quạt Điện');
INSERT INTO Loai VALUES ('ONG', N'Ống Nước');
INSERT INTO Loai VALUES ('VAN', N'Van Nước');
INSERT INTO Loai VALUES ('BOM', N'Bơm Nước');
INSERT INTO Loai VALUES ('DAYD', N'Dây Điện');
INSERT INTO Loai VALUES ('CBKN', N'Công Tắc Điện');
INSERT INTO Loai VALUES ('CT', N'Chiết Áp');
INSERT INTO Loai VALUES ('NS', N'Nước Sơn');
INSERT INTO Loai VALUES ('DINH', N'Đinh');  -- Thêm loại 'Đinh'
INSERT INTO Loai VALUES ('FE', N'Sắt');  -- Thêm loại 'Sắt'
INSERT INTO Loai VALUES ('CAT', N'Cát');  -- Thêm loại 'Cát'
INSERT INTO Loai VALUES ('GCH', N'Gạch');  -- Thêm loại 'Gạch'
INSERT INTO Loai VALUES ('CO', N'Co Nước');  -- Thêm loại 'Co Nước'
INSERT INTO Loai VALUES ('ORT', N'Ống Rút Thẳng');  -- Thêm loại 'Ống Rút Thẳng'
INSERT INTO Loai VALUES ('ORC', N'Ống Rút Co');  -- Thêm loại 'Ống Rút Co'
INSERT INTO Loai VALUES ('XM', N'Xi Măng');  -- Thêm loại 'Xi Măng'
INSERT INTO Loai VALUES ('DA', N'Đá');  -- Thêm loại 'Đá'

-- them san pham

INSERT INTO Sanpham VALUES ('BD01', N'Bóng Đèn LED 7W', 100, 'BD', 'Cái', 25000, 27500, N'Mới');
INSERT INTO Sanpham VALUES ('BD02', N'Bóng Đèn LED 12W', 100, 'BD', 'Cái', 35000, 38500, N'Mới');
INSERT INTO Sanpham VALUES ('BD03', N'Bóng Đèn Compact 18W', 100, 'BD', 'Cái', 45000, 49500, N'Mới');

INSERT INTO Sanpham VALUES ('CB01', N'Cầu Dao 1P', 50, 'CB', 'Cái', 40000, 44000, N'Mới');
INSERT INTO Sanpham VALUES ('CB02', N'Cầu Dao 2P', 50, 'CB', 'Cái', 60000, 66000, N'Mới');

INSERT INTO Sanpham VALUES ('DAU01', N'Ổ Cắm Đơn 16A', 100, 'DAU', 'Cái', 15000, 16500, N'Mới');
INSERT INTO Sanpham VALUES ('DAU02', N'Ổ Cắm Đơn 20A', 100, 'DAU', 'Cái', 20000, 22000, N'Mới');

INSERT INTO Sanpham VALUES ('DAO01', N'Ổ Cắm Đôi 16A', 100, 'DAO', 'Cái', 25000, 27500, N'Mới');
INSERT INTO Sanpham VALUES ('DAO02', N'Ổ Cắm Đôi 20A', 100, 'DAO', 'Cái', 30000, 33000, N'Mới');

INSERT INTO Sanpham VALUES ('QUAT01', N'Quạt Điện Treo Tường', 50, 'QUAT', 'Cái', 500000, 550000, N'Mới');
INSERT INTO Sanpham VALUES ('QUAT02', N'Quạt Điện Để Bàn', 50, 'QUAT', 'Cái', 250000, 275000, N'Mới');

INSERT INTO Sanpham VALUES ('ONG01', N'Ống Nước PVC 21', 100, 'ONG', 'Cái', 10000, 11000, N'Mới');
INSERT INTO Sanpham VALUES ('ONG02', N'Ống Nước PVC 27', 100, 'ONG', 'Cái', 15000, 16500, N'Mới');

INSERT INTO Sanpham VALUES ('VAN01', N'Van Nước 1 chiều', 100, 'VAN', 'Cái', 30000, 33000, N'Mới');
INSERT INTO Sanpham VALUES ('VAN02', N'Van Nước 2 chiều', 100, 'VAN', 'Cái', 45000, 49500, N'Mới');

INSERT INTO Sanpham VALUES ('BOM01', N'Bơm Nước Mini 12V', 50, 'BOM', 'Cái', 150000, 165000, N'Mới');
INSERT INTO Sanpham VALUES ('BOM02', N'Bơm Nước Công Nghiệp', 20, 'BOM', 'Cái', 2500000, 2750000, N'Mới');

INSERT INTO Sanpham VALUES ('DAYD01', N'Dây Điện Cadivi 2.5mm', 100, 'DAYD', 'Cuộn', 150000, 165000, N'Mới');
INSERT INTO Sanpham VALUES ('DAYD02', N'Dây Điện Cadivi 4.0mm', 100, 'DAYD', 'Cuộn', 200000, 220000, N'Mới');

INSERT INTO Sanpham VALUES ('CBKN01', N'Công Tắc Điện 1 chiều', 100, 'CBKN', 'Cái', 20000, 22000, N'Mới');
INSERT INTO Sanpham VALUES ('CBKN02', N'Công Tắc Điện 2 chiều', 100, 'CBKN', 'Cái', 30000, 33000, N'Mới');

INSERT INTO Sanpham VALUES ('CT01', N'Chiết Áp Đèn LED', 50, 'CT', 'Cái', 50000, 55000, N'Mới');
INSERT INTO Sanpham VALUES ('CT02', N'Chiết Áp Quạt Điện', 50, 'CT', 'Cái', 60000, 66000, N'Mới');

INSERT INTO Sanpham VALUES ('NS01', N'Nước Sơn Dulux 5L', 100, 'NS', 'Thùng', 500000, 550000, N'Mới');
INSERT INTO Sanpham VALUES ('NS02', N'Nước Sơn Kova 5L', 100, 'NS', 'Thùng', 450000, 495000, N'Mới');

INSERT INTO Sanpham VALUES ('DINH01', N'Đinh 1.5p', 100 , 'DINH', 'KG', 22000, 24200, N'Mới');
INSERT INTO Sanpham VALUES ('DINH02', N'Đinh 2p', 100, 'DINH', 'KG', 16500, 18400, N'Mới');
INSERT INTO Sanpham VALUES ('DINH03', N'Đinh 2.5p', 100, 'DINH', 'KG', 16500, 18400, N'Mới');
INSERT INTO Sanpham VALUES ('DINH04', N'Đinh 3p', 100, 'DINH', 'KG', 14000, 16100, N'Mới');
INSERT INTO Sanpham VALUES ('DINH05', N'Đinh 4p', 100, 'DINH', 'KG', 13000, 15000, N'Mới');
INSERT INTO Sanpham VALUES ('DINH06', N'Đinh 5p', 100, 'DINH', 'KG', 12000, 14400, N'Mới');
INSERT INTO Sanpham VALUES ('DINH07', N'Đinh 6p', 100, 'DINH', 'KG', 12100, 14400, N'Mới');
INSERT INTO Sanpham VALUES ('DINH08', N'Đinh 7p', 100, 'DINH', 'KG', 12000, 14500, N'Mới');
INSERT INTO Sanpham VALUES ('DINH09', N'Đinh 8p', 100, 'DINH', 'KG', 12500, 14300, N'Mới');
INSERT INTO Sanpham VALUES ('DINH10', N'Đinh 10p', 100, 'DINH', 'KG', 12000, 14500, N'Mới');
INSERT INTO Sanpham VALUES ('DINH11', N'Đinh 12p', 100, 'DINH', 'KG', 12400, 14400, N'Mới');
INSERT INTO Sanpham VALUES ('DINH12', N'Đinh dù 4p', 100, 'DINH', 'KG', 15500, 18400, N'Mới');
INSERT INTO Sanpham VALUES ('DINH13', N'Đinh dù 5p', 100, 'DINH', 'KG', 15200, 18000, N'Mới');

INSERT INTO Sanpham VALUES ('FE01', N'Sắt 6', 100, 'FE', N'KG', 18740, 20750, N'Mới');
INSERT INTO Sanpham VALUES ('FE03', N'Sắt 8', 100, 'FE', N'KG', 18750, 20700, N'Mới');
INSERT INTO Sanpham VALUES ('FE04', N'Sắt 10', 100, 'FE', N'Cây', 116800, 120500, N'Mới');
INSERT INTO Sanpham VALUES ('FE05', N'Sắt 12', 100, 'FE', N'Cây', 183500, 187500, N'Mới');
INSERT INTO Sanpham VALUES ('FE06', N'Sắt 14', 100, 'FE', N'Cây', 252500, 25500, N'Mới');
INSERT INTO Sanpham VALUES ('FE07', N'Sắt 16', 100, 'FE', N'Cây', 325500, 330100, N'Mới');
INSERT INTO Sanpham VALUES ('FE08', N'Sắt 18', 100, 'FE', N'Cây', 41700, 423500, N'Mới');
INSERT INTO Sanpham VALUES ('FE09', N'Sắt 20', 100, 'FE', N'Cây', 515000, 523500, N'Mới');
INSERT INTO Sanpham VALUES ('FE10', N'Đinh + Kẽm Buộc', 100, 'FE', N'KG', 12000, 13500, N'Mới');
INSERT INTO Sanpham VALUES ('FE11', N'Tai Dê', 100, 'FE', N'KG', 13700, 15000, N'Mới');

INSERT INTO Sanpham VALUES ('CAT01', N'Cát Loại 1 (Khối)', 100, 'CAT', N'Khối', 290000, 300000, N'Mới');
INSERT INTO Sanpham VALUES ('CAT02', N'Cát Loại 2 (Khối)', 100, 'CAT', N'Khối', 245000, 254000, N'Mới');
INSERT INTO Sanpham VALUES ('CAT03', N'Cát Loại 1 (Xe)', 100, 'CAT', N'Xe', 725000, 755000, N'Mới');
INSERT INTO Sanpham VALUES ('CAT04', N'Cát Loại 2 (Xe)', 100, 'CAT', N'Xe', 612000, 634000, N'Mới');

INSERT INTO Sanpham VALUES ('GCH01', N'Gạch Ống Đậm', 100, 'GCH', N'Viên', 950, 965, N'Mới');
INSERT INTO Sanpham VALUES ('GCH02', N'Gạch Ống Lợt', 100, 'GCH', N'Viên', 900, 935, N'Mới');
INSERT INTO Sanpham VALUES ('GCH03', N'Gạch Thẻ Đậm', 100, 'GCH', N'Viên', 980, 1010, N'Mới');
INSERT INTO Sanpham VALUES ('GCH04', N'Gạch Thẻ Lợt', 100, 'GCH', N'Viên', 950, 980, N'Mới');

INSERT INTO Sanpham VALUES ('ON01', N'Ống Nước 21', 100, 'ONG', N'Ống', 7100, 7810, N'Mới');
INSERT INTO Sanpham VALUES ('ON02', N'Ống Nước 27', 100, 'ONG', N'Ống', 10100, 11110, N'Mới');
INSERT INTO Sanpham VALUES ('ON03', N'Ống Nước 34', 100, 'ONG', N'Ống', 14100, 15510, N'Mới');
INSERT INTO Sanpham VALUES ('ON04', N'Ống Nước 42', 100, 'ONG', N'Ống', 18700, 20570, N'Mới');
INSERT INTO Sanpham VALUES ('ON05', N'Ống Nước 49', 100, 'ONG', N'Ống', 24500, 26950, N'Mới');
INSERT INTO Sanpham VALUES ('ON06', N'Ống Nước 60', 100, 'ONG', N'Ống', 25900, 28490, N'Mới');
INSERT INTO Sanpham VALUES ('ON07', N'Ống Nước 90', 100, 'ONG', N'Ống', 33000, 36300, N'Mới');
INSERT INTO Sanpham VALUES ('ON08', N'Ống Nước 114', 100, 'ONG', N'Ống', 77880, 86680, N'Mới');

INSERT INTO Sanpham VALUES ('VAN01', N'Van Nước 21', 100, 'VAN', N'Cái', 15700, 17270, N'Mới');
INSERT INTO Sanpham VALUES ('VAN02', N'Van Nước 27', 100, 'VAN', N'Cái', 18400, 20240, N'Mới');
INSERT INTO Sanpham VALUES ('VAN03', N'Van Nước 34', 100, 'VAN', N'Cái', 31200, 34320, N'Mới');
INSERT INTO Sanpham VALUES ('VAN04', N'Van Nước 42', 100, 'VAN', N'Cái', 45800, 50380, N'Mới');
INSERT INTO Sanpham VALUES ('VAN05', N'Van Nước 49', 100, 'VAN', N'Cái', 68700, 75570, N'Mới');

INSERT INTO Sanpham VALUES ('CO01', N'Co Nước 21', 100, 'CO', N'Cái', 2400, 2640, N'Mới');
INSERT INTO Sanpham VALUES ('CO02', N'Co Nước 27', 100, 'CO', N'Cái', 3900, 4290, N'Mới');
INSERT INTO Sanpham VALUES ('CO03', N'Co Nước 34', 100, 'CO', N'Cái', 5500, 6050, N'Mới');
INSERT INTO Sanpham VALUES ('CO04', N'Co Nước 42', 100, 'CO', N'Cái', 8300, 9130, N'Mới');
INSERT INTO Sanpham VALUES ('CO05', N'Co Nước 49', 100, 'CO', N'Cái', 13100, 14410, N'Mới');
INSERT INTO Sanpham VALUES ('CO06', N'Co Nước 60', 100, 'CO', N'Cái', 20900, 22990, N'Mới');
INSERT INTO Sanpham VALUES ('CO07', N'Co Nước 90', 100, 'CO', N'Cái', 52000, 57200, N'Mới');
INSERT INTO Sanpham VALUES ('CO08', N'Co Nước 114', 100, 'CO', N'Cái', 119900, 131890, N'Mới');

INSERT INTO Sanpham VALUES ('ORT01', N'Ống Rút Thẳng 21-27', 100, 'ORT', N'Cái', 2100, 2310, N'Mới');
INSERT INTO Sanpham VALUES ('ORT02', N'Ống Rút Thẳng 27-34', 100, 'ORT', N'Cái', 3000, 3300, N'Mới');
INSERT INTO Sanpham VALUES ('ORT03', N'Ống Rút Thẳng 34-42', 100, 'ORT', N'Cái', 4600, 5060, N'Mới');
INSERT INTO Sanpham VALUES ('ORT04', N'Ống Rút Thẳng 42-49', 100, 'ORT', N'Cái', 6700, 7370, N'Mới');
INSERT INTO Sanpham VALUES ('ORT05', N'Ống Rút Thẳng 49-60', 100, 'ORT', N'Cái', 10100, 11110, N'Mới');
INSERT INTO Sanpham VALUES ('ORT06', N'Ống Rút Thẳng 49-34', 100, 'ORT', N'Cái', 6300, 6930, N'Mới');
INSERT INTO Sanpham VALUES ('ORT07', N'Ống Rút Thẳng 60-42', 100, 'ORT', N'Cái', 9800, 10780, N'Mới');

INSERT INTO Sanpham VALUES ('ORC01', N'Ống Rút Co 21-27', 100, 'ORC', N'Cái', 2400, 2640, N'Mới');
INSERT INTO Sanpham VALUES ('ORC02', N'Ống Rút Co 27-34', 100, 'ORC', N'Cái', 3700, 4070, N'Mới');
INSERT INTO Sanpham VALUES ('ORC03', N'Ống Rút Co 34-42', 100, 'ORC', N'Cái', 6400, 6740, N'Mới');
INSERT INTO Sanpham VALUES ('ORC04', N'Ống Rút Co 42-49', 100, 'ORC', N'Cái', 6800, 7000, N'Mới');
INSERT INTO Sanpham VALUES ('ORC05', N'Ống Rút Co 49-60', 100, 'ORC', N'Cái', 7350, 7580, N'Mới');
INSERT INTO Sanpham VALUES ('ORC06', N'Ống Rút Co 49-34', 100, 'ORC', N'Cái', 7600, 8360, N'Mới');
INSERT INTO Sanpham VALUES ('ORC07', N'Ống Rút Co 60-42', 100, 'ORC', N'Cái', 8100, 8450, N'Mới');

INSERT INTO Sanpham VALUES ('XM01', N'Xi Măng Hà Tiên', 100, 'XM', N'Bao', 88000, 90000, N'Mới');
INSERT INTO Sanpham VALUES ('XM02', N'Xi Măng An Giang', 100, 'XM', N'Bao', 75800, 76500, N'Mới');

INSERT INTO Sanpham VALUES ('DA01', N'Đá 1x2', 100, 'DA', N'Khối', 295000, 300000, N'Mới');
INSERT INTO Sanpham VALUES ('DA02', N'Đá 4x6', 100, 'DA', N'Khối', 300000, 305000, N'Mới');
INSERT INTO Sanpham VALUES ('DA03', N'Đá Mi', 100, 'DA', N'Khối', 290000, 295000, N'Mới');

INSERT INTO Sanpham VALUES ('NS01', N'Nước Sơn Dulux', 100, 'NS', N'Hộp', 980000, 1025000, N'Mới');
INSERT INTO Sanpham VALUES ('NS02', N'Nước Sơn Kova Art', 100, 'NS', N'Hộp', 920000, 975000, N'Mới');
INSERT INTO Sanpham VALUES ('NS03', N'Nước Sơn JoTon', 100, 'NS', N'Hộp', 550000, 570000, N'Mới');
INSERT INTO Sanpham VALUES ('NS04', N'Nước Sơn Kova Art', 100, 'NS', N'Hộp', 950000, 980000, N'Mới');
INSERT INTO Sanpham VALUES ('NS05', N'Nước Sơn Xịt', 100, 'NS', N'Chai', 41000, 45000, N'Mới');




go
-- Stored procedure lấy ra các hóa đơn trong khoảng thời gian từ @start đến @end.
create proc USP_HoaDon
@start smalldatetime, @end smalldatetime as 
begin 
	select * from Hoadon where ngaygd >= @start+'00:00:00' and ngaygd <= @end+ '23:59:59' 
end
go

-- Stored procedure lấy ra thông tin chi tiết của các hóa đơn trong khoảng thời gian từ @start đến @end.
create proc USP_HoaDonChiTiet
@start smalldatetime, @end smalldatetime as 
begin 
	select t.masp, t.tensp, t.dvtinh, t.giaban, t.soluong, t.thanhtien, h.ngaygd from thongtinhoadon t, Hoadon h where t.idhd = h.mahd and ngaygd >= @start+'00:00:00' and ngaygd <= @end+ '23:59:59' 
end
go

-- Stored procedure lấy ra các thông tin về nhập hàng trong khoảng thời gian từ @start đến @end.
create proc USP_NhapHang
@start smalldatetime, @end smalldatetime as
begin 
	select * from Nhaphang where ngaynhap >= @start+'00:00:00' and ngaynhap <= @end+ '23:59:59' 
end
go

-- Stored procedure lấy ra các hóa đơn được tạo trong ngày hiện tại.
create proc USP_BaoCaoNgay as
begin 
	select * from Hoadon where ngaygd >= GETDATE()+'00:00:00' and ngaygd <= GETDATE()+ '23:59:59' 
end
go
-- Stored procedure lấy ra các hóa đơn được tạo trong ngày hiện tại.
create proc USP_BaoCaoNgay as
begin 
    select * from Hoadon where ngaygd >= CONVERT(date, GETDATE()) and ngaygd < CONVERT(date, DATEADD(day, 1, GETDATE()))
end
go