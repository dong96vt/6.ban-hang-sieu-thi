create table nhanvien (
ma varchar(10) primary key,
mahienthi nvarchar(20),
hoten nvarchar(200),
quequan nvarchar(100),
diachi nvarchar(100),
gioitinh int,
ngaysinh date,
luong int,
chucvu nvarchar(100),
)

create table hanghoa (
ma varchar(10) primary key,
mahienthi nvarchar(20),
ten nvarchar(200),
soluongcon int,
loaihang nvarchar(100),
gia int,
)

create table khachhang (
ma varchar(10) primary key,
mahienthi nvarchar(20),
hoten nvarchar(200),
diachi nvarchar(100),
gioitinh int,
ngaysinh date,
)

create table hoadon (
ma varchar(10) primary key,
mahienthi nvarchar(20),
khachhangma varchar(10),
nhanvienma varchar(10),
ngayviet datetime,
khuyenmai float,
tonggia int,
)

create table sanpham (
ma varchar(10) primary key,
soluong int,
hanghoama varchar(10),
hoadonma varchar(10),
)




