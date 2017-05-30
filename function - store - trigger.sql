--Kiểm tra đăng nhập
create function dangnhap(@id varchar(20), @pass varchar(100)) returns varchar(10) as
begin
	declare @ma varchar(10)
	
	if exists (select * from nhanvien where id=@id and pass=@pass)
		select @ma= a.ma from (select * from nhanvien where id=@id and pass=@pass) a
	else 	
		begin
			if exists (select * from nhanvien where id=@id) set @ma='-1'
			else set @ma='-2'
		end
	return @ma
end
<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> ffc0d83686e18c8099332b936314d7746828df95
 -- Kiểm tra số lượng sản phẩm còn lại
create function check_kho(@ma varchar(10), @soluong int) returns int as
begin
	declare @soluongcon int
	select @soluongcon= a.soluongcon from (select * from hanghoa where ma=@ma) a
	if (@soluong<@soluongcon) return 1
	return 0 
end
-- Trigger xóa hóa đơn, sản phẩm không hợp lệ đồng thời update lại số lượng sản phẩm khi insert sản phẩm
create trigger thanhtoan on sanpham for insert as
begin
	declare @mahh varchar(10)
	declare @soluong int
	select @mahh= a.ma from (select * from inserted) a
	select @soluong= a.soluong from (select * from inserted) a
	UPDATE hanghoa
	Set soluongcon=soluongcon-@soluong
	where ma=@mahh
	delete hoadon where khachhangma = null
	delete hoadon where ma in (Select a.ma from hoadon a left join sanpham b on a.ma=b.hoadonma group by a.ma  having COUNT(b.ma) = 0)
	delete sanpham where hanghoama = null
end
-------------------------------------------proc them sua xoa nhan vien---------------
=======
-----------------nhanvien--------------
>>>>>>> f1e85b1b0b1834a071756614e13c2def702f3266
<<<<<<< HEAD
=======
=======
-----------------nhanvien--------------
>>>>>>> f1e85b1b0b1834a071756614e13c2def702f3266
>>>>>>> ffc0d83686e18c8099332b936314d7746828df95
create proc ThemNhanvien
@ma	varchar(10),
@mahienthi	nvarchar(20),
@hoten	nvarchar(200),
@quequan	nvarchar(100),
@diachi	nvarchar(100),
@gioitinh	int,
@ngaysinh	date,
@luong	int,
@chucvu	nvarchar(100),
@id varchar(20),
@pass varchar(100)
as
begin
	insert into nhanvien values(@ma,@mahienthi,@hoten,@quequan,@diachi,@gioitinh,@ngaysinh,@luong,@chucvu,@id,@pass)
end
<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> ffc0d83686e18c8099332b936314d7746828df95
	-----------------------
	
GO
/****** Object:  StoredProcedure [dbo].[UpdateNhanvien]    Script Date: 4/25/2017 10:38:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------Update
=======
----
>>>>>>> f1e85b1b0b1834a071756614e13c2def702f3266
<<<<<<< HEAD
=======
=======
----
>>>>>>> f1e85b1b0b1834a071756614e13c2def702f3266
>>>>>>> ffc0d83686e18c8099332b936314d7746828df95
create proc UpdateNhanvien
@ma	varchar(10),
@mahienthi	nvarchar(20),
@hoten	nvarchar(200),
@quequan	nvarchar(100),
@diachi	nvarchar(100),
@gioitinh	int,
@ngaysinh	date,
@luong	int,
@chucvu	nvarchar(100),
@id varchar(20),
@pass varchar(100)
as
begin
	Update nhanvien set mahienthi = @mahienthi,hoten = @hoten, quequan = @quequan,diachi= @diachi,gioitinh = @gioitinh,ngaysinh = @ngaysinh,luong = @luong,chucvu = @chucvu,@id=id,@pass=pass where ma = @ma
end
<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> ffc0d83686e18c8099332b936314d7746828df95
	

GO
/****** Object:  StoredProcedure [dbo].[XoaNhanvien]    Script Date: 4/25/2017 10:39:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
=======
----
>>>>>>> f1e85b1b0b1834a071756614e13c2def702f3266
<<<<<<< HEAD
=======
=======
----
>>>>>>> f1e85b1b0b1834a071756614e13c2def702f3266
>>>>>>> ffc0d83686e18c8099332b936314d7746828df95
create proc XoaNhanvien
@ma	varchar(10)
as
begin
	delete from nhanvien where ma = @ma
end 