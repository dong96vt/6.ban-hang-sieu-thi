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
-----------------nhanvien--------------
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
----
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
----
create proc XoaNhanvien
@ma	varchar(10)
as
begin
	delete from nhanvien where ma = @ma
end 