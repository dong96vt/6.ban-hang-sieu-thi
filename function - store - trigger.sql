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