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
