create database QLVLXD
go

use QLVLXD;
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

insert into Account values ('NV02', '1962026656160185351301320480154111117132155', 'AD', N'Bật');
insert into Account values ('NV01', '1962026656160185351301320480154111117132155', 'NV', N'Bật');
insert into Account values ('NV03', '1962026656160185351301320480154111117132155', 'NV', N'Bật');
insert into Account values ('NV04', '1962026656160185351301320480154111117132155', 'NV', N'Bật');

-- them khach hang
insert into Khachhang values ('KH00', N'Khách lẻ',N'Trống' , '1990/01/01', N'Trống',N'Tắt', 0, 0);
insert into Khachhang values ('KH01', N'Kiều Văn Khang','0338642666' , '2000/05/18', N'Phú Xuân, Phú Tân, An Giang',N'Bật', 0, 0);
insert into Khachhang values ('KH02', N'Cao Trường An', '0338642667', '1999/07/24', N'Phú Hòa, Tp Long Xuyên, An Giang',N'Bật', 0, 0);
insert into Khachhang values ('KH03', N'Nguyễn Minh Tiến','0338642668', '2000/01/18', N'Phú Hòa, Tp Long Xuyên, An Giang',N'Bật', 0, 0);
insert into Khachhang values ('KH04', N'Trương Huỳnh Phú Quí','0338642669', '2000/01/01', N'Núi Sập, Thoại Sơn, An Giang',N'Bật', 0, 0);
insert into Khachhang values ('KH05', N'Bùi Huy Khang','0338642660', '2000/12/12', N'Châu Đốc, An Giang',N'Bật', 0, 0);


--them loai
insert into Loai values ('FE', N'Sắt');
insert into Loai values ('CAT', N'Cát');
insert into Loai values ('XM', N'Xi Măng');
insert into Loai values ('DINH', N'Đinh');
insert into Loai values ('DA', N'Đá');
insert into Loai values ('GCH', N'Gạch');
insert into Loai values ('ON', N'Ống Nước');
insert into Loai values ('VAN', N'Van Nước');
insert into Loai values ('CO', N'Co Nước');
insert into Loai values ('ORT', N'Ống Rút Thẳng');
insert into Loai values ('ORC', N'Ống Rút Co');
insert into Loai values ('NS', N'Nước Sơn');

-- them san pham

insert into Sanpham values ('DINH01', N'Đinh 1.5p', 100 , 'DINH', 'KG', 22000, 24200, N'Mới');
insert into Sanpham values ('DINH02', N'Đinh 2p', 100, 'DINH', 'KG', 16500, 18400, N'Mới');
insert into Sanpham values ('DINH03', N'Đinh 2.5p', 100, 'DINH', 'KG', 16500, 18400, N'Mới');
insert into Sanpham values ('DINH04', N'Đinh 3p', 100, 'DINH', 'KG', 14000, 16100, N'Mới');
insert into Sanpham values ('DINH05', N'Đinh 4p', 100, 'DINH', 'KG', 13000, 15000, N'Mới');
insert into Sanpham values ('DINH06', N'Đinh 5p', 100, 'DINH', 'KG', 12000, 14400, N'Mới');
insert into Sanpham values ('DINH07', N'Đinh 6p', 100, 'DINH', 'KG', 12100, 14400, N'Mới');
insert into Sanpham values ('DINH08', N'Đinh 7p', 100, 'DINH', 'KG', 12000, 14500, N'Mới');
insert into Sanpham values ('DINH09', N'Đinh 8p', 100, 'DINH', 'KG', 12500, 14300, N'Mới');
insert into Sanpham values ('DINH10', N'Đinh 10p', 100, 'DINH', 'KG', 12000, 14500, N'Mới');
insert into Sanpham values ('DINH11', N'Đinh 12p', 100, 'DINH', 'KG', 12400, 14400, N'Mới');
insert into Sanpham values ('DINH12', N'Đinh dù 4p', 100, 'DINH', 'KG', 15500, 18400, N'Mới');
insert into Sanpham values ('DINH13', N'Đinh dù 5p', 100, 'DINH', 'KG', 15200, 18000, N'Mới');

insert into Sanpham values ('FE01', N'Sắt 6', 100, 'FE', N'KG', 18740, 20750, N'Mới');
insert into Sanpham values ('FE03', N'Sắt 8', 100, 'FE', N'KG', 18750, 20700, N'Mới');
insert into Sanpham values ('FE04', N'Sắt 10', 100, 'FE', N'Cây', 116800, 120500, N'Mới');
insert into Sanpham values ('FE05', N'Sắt 12', 100, 'FE', N'Cây', 183500, 187500, N'Mới');
insert into Sanpham values ('FE06', N'Sắt 14', 100, 'FE', N'Cây', 252500, 25500, N'Mới');
insert into Sanpham values ('FE07', N'Sắt 16',100, 'FE', N'Cây', 325500, 330100, N'Mới');
insert into Sanpham values ('FE08', N'Sắt 18',100, 'FE', N'Cây', 41700, 423500, N'Mới');
insert into Sanpham values ('FE09', N'Sắt 20',100, 'FE', N'Cây', 515000, 523500, N'Mới');
insert into Sanpham values ('FE0', N'Đinh + Kẽm Buộc',100, 'FE', N'KG', 12000, 13500, N'Mới');
insert into Sanpham values ('FE00', N'Tai Dê',100, 'FE', N'KG', 13700, 15000, N'Mới');

insert into Sanpham values ('CAT01', N'Cát Loại 1(Khối)',100, 'CAT', N'Khối', 290000, 300000, N'Mới');
insert into Sanpham values ('CAT02', N'Cát Loại 2(Khối)',100, 'CAT', N'Khối', 245000, 254000, N'Mới');
insert into Sanpham values ('CAT03', N'Cát Loại 1(Xe)',100, 'CAT', N'Xe', 725000, 755000, N'Mới');
insert into Sanpham values ('CAT04', N'Cát Loại 2(Xe)',100, 'CAT', N'Xe', 612000, 634000, N'Mới');

insert into Sanpham values ('GCH01', N'Gạch Ống Đậm',100, 'GCH', N'Viên', 950, 965, N'Mới');
insert into Sanpham values ('GCH02', N'Gạch Ống Lợt',100, 'GCH', N'Viên', 900, 935, N'Mới');
insert into Sanpham values ('GCH03', N'Gạch Thẻ Đậm',100, 'GCH', N'Viên', 980, 1010, N'Mới');
insert into Sanpham values ('GCH04', N'Gạch Thẻ Lợt',100, 'GCH', N'Viên', 950, 980, N'Mới');


insert into Sanpham values ('ON01', N'Ống NƯớc 21',100, 'ON', N'Ống', 7100, 7810, N'Mới');
insert into Sanpham values ('ON02', N'Ống NƯớc 27',100, 'ON', N'Ống', 1010, 1110, N'Mới');
insert into Sanpham values ('ON03', N'Ống NƯớc 34',100, 'ON', N'Ống', 14100, 15510, N'Mới');
insert into Sanpham values ('ON04', N'Ống NƯớc 42',100, 'ON', N'Ống', 18700, 20570, N'Mới');
insert into Sanpham values ('ON05', N'Ống NƯớc 49',100, 'ON', N'Ống', 24500, 26950, N'Mới');
insert into Sanpham values ('ON06', N'Ống NƯớc 60',100, 'ON', N'Ống', 25900, 28490, N'Mới');
insert into Sanpham values ('ON07', N'Ống NƯớc 90',100, 'ON', N'Ống', 33000, 36300, N'Mới');
insert into Sanpham values ('ON08', N'Ống NƯớc 114',100, 'ON', N'Ống', 778800, 86680, N'Mới');

insert into Sanpham values ('VAN01', N'Van Nước 21',100, 'VAN', N'Cái', 15700, 17270, N'Mới');
insert into Sanpham values ('VAN02', N'Van Nước 27',100, 'VAN', N'Cái', 18400, 20240, N'Mới');
insert into Sanpham values ('VAN03', N'Van Nước 34',100, 'VAN', N'Cái', 31200, 34320, N'Mới');
insert into Sanpham values ('VAN04', N'Van Nước 42',100, 'VAN', N'Cái', 45800, 50380, N'Mới');
insert into Sanpham values ('VAN05', N'Van Nước 49',100, 'VAN', N'Cái', 68700, 75570, N'Mới');

insert into Sanpham values ('CO01', N'Co Nước 21',100, 'CO', N'Cái', 2400, 2640, N'Mới');
insert into Sanpham values ('CO02', N'Co Nước 27',100, 'CO', N'Cái', 3900, 4290, N'Mới');
insert into Sanpham values ('CO03', N'Co Nước 34',100, 'CO', N'Cái', 5500, 6050, N'Mới');
insert into Sanpham values ('CO04', N'Co Nước 42',100, 'CO', N'Cái', 8300, 9130, N'Mới');
insert into Sanpham values ('CO05', N'Co Nước 49',100, 'CO', N'Cái', 13100, 14410, N'Mới');
insert into Sanpham values ('CO06', N'Co Nước 60',100, 'CO', N'Cái', 20900, 22990, N'Mới');
insert into Sanpham values ('CO07', N'Co Nước 90',100, 'CO', N'Cái', 52000, 57200, N'Mới');
insert into Sanpham values ('CO08', N'Co Nước 114',100, 'CO', N'Cái', 119900, 131890, N'Mới');

insert into Sanpham values ('ORT01', N'Ống Rút Thẳng 21-27',100, 'ORT', N'Cái', 2100, 2310, N'Mới');
insert into Sanpham values ('ORT02', N'Ống Rút Thẳng 27-34',100, 'ORT', N'Cái', 300, 3300, N'Mới');
insert into Sanpham values ('ORT03', N'Ống Rút Thẳng 34-42',100, 'ORT', N'Cái', 4600, 5060, N'Mới');
insert into Sanpham values ('ORT04', N'Ống Rút Thẳng 42-49',100, 'ORT', N'Cái', 6700, 7370, N'Mới');
insert into Sanpham values ('ORT05', N'Ống Rút Thẳng 49-60',100, 'ORT', N'Cái', 10100, 11110, N'Mới');
insert into Sanpham values ('ORT06', N'Ống Rút Thẳng 49-34',100, 'ORT', N'Cái', 6300, 6930, N'Mới');
insert into Sanpham values ('ORT07', N'Ống Rút Thẳng 60-42',100, 'ORT', N'Cái', 9800, 10780, N'Mới');

insert into Sanpham values ('ORC01', N'Ống Rút Co 21-27',100, 'ORC', N'Cái', 2400, 2640, N'Mới');
insert into Sanpham values ('ORC02', N'Ống Rút Co 27-34',100, 'ORC', N'Cái', 3700, 4070, N'Mới');
insert into Sanpham values ('ORC03', N'Ống Rút Co 34-42',100, 'ORC', N'Cái', 6400, 6740, N'Mới');
insert into Sanpham values ('ORC04', N'Ống Rút Co 42-49',100, 'ORC', N'Cái', 6800, 7000, N'Mới');
insert into Sanpham values ('ORC05', N'Ống Rút Co 49-60',100, 'ORC', N'Cái', 7350, 7580, N'Mới');
insert into Sanpham values ('ORC06', N'Ống Rút Co 49-34',100, 'ORC', N'Cái', 7600, 8360, N'Mới');
insert into Sanpham values ('ORC07', N'Ống Rút Co 60-42', 100, 'ORC', N'Cái', 8100, 8450, N'Mới');

insert into Sanpham values ('XM01', N'Xi Măng Hà Tiên',100, 'XM', N'Bao', 88000, 90000, N'Mới');
insert into Sanpham values ('XM02', N'Xi Măng An Giang',100, 'XM', N'Bao', 75800, 76500, N'Mới');

insert into Sanpham values ('DA01', N'Đá 1x2',100, 'DA', N'Khối', 295000, 300000, N'Mới');
insert into Sanpham values ('DA02', N'Đá 4x6',100, 'DA', N'Khối', 30000, 305000, N'Mới');
insert into Sanpham values ('DA03', N'Đá Mi',100, 'DA', N'Khối', 290000, 295000, N'Mới');

insert into Sanpham values ('NS01', N'Nước Sơn Dulux', 100, 'NS', N'Hôp', 980000, 1025000, N'Mới');
insert into Sanpham values ('NS02', N'Nước Sơn Kova Art', 100, 'NS', N'Hộp', 920000, 975000, N'Mới');
insert into Sanpham values ('NS03', N'Nước Sơn JoTon', 100, 'NS', N'Hộp', 550000, 570000, N'Mới');
insert into Sanpham values ('NS04', N'Nước Sơn Kova Art', 100, 'NS', N'Hộp', 9500000, 980000, N'Mới');
insert into Sanpham values ('NS05', N'Nước Sơn Xịt',100, 'NS', N'Chai', 41000, 45000, N'Mới');

insert into Chucvu values ('AD', N'Quản Lý');
insert into Chucvu values ('NV', N'Nhân Viên');

insert into nhanvien values ('NV01', N'Lý Kim Vân', 'NV', '0338426663', N'1987/5/15', N'Ninh Kiều, Cái Răng, Cần Thơ',N'Bật');
insert into nhanvien values ('NV02', N'Khang Kiều Văn', 'AD', '0338931522', N'2000/5/13', N'656, P.Mỹ Phước, TP Long Xuyên, An Giang',N'Bật');
insert into nhanvien values ('NV03', N'Nguyễn Kim Tuyền', 'NV', '0338428856', N'1990/12/15', N'Long Xuyên, An Giang',N'Bật');
insert into nhanvien values ('NV04', N'Lê Thị Lệ', 'NV', '0338889900', N'1995/8/10', N'Ninh Kiều, Cái Răng, Cần Thơ',N'Bật');
--select * from Account
--select * from Hoadon
--select * from Khachhang
--select * from Thongtinhoadon
--select * from Nhaphang
--select * from sanpham
--select * from nhanvien

go
create proc USP_HoaDon
@start smalldatetime, @end smalldatetime as 
begin 
	select * from Hoadon where ngaygd >= @start+'00:00:00' and ngaygd <= @end+ '23:59:59' 
end
go

create proc USP_HoaDonChiTiet
@start smalldatetime, @end smalldatetime as 
begin 
	select t.masp, t.tensp, t.dvtinh, t.giaban, t.soluong, t.thanhtien, h.ngaygd from thongtinhoadon t, Hoadon h where t.idhd = h.mahd and ngaygd >= @start+'00:00:00' and ngaygd <= @end+ '23:59:59' 
end
go

create proc USP_NhapHang
@start smalldatetime, @end smalldatetime as 
begin 
	select * from Nhaphang where ngaynhap >= @start+'00:00:00' and ngaynhap <= @end+ '23:59:59' 
end
go

create proc USP_BaoCaoNgay as
begin 
	select * from Hoadon where ngaygd >= GETDATE()+'00:00:00' and ngaygd <= GETDATE()+ '23:59:59' 
end
go

