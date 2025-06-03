------PRODUCTOS-------
create procedure sp_listarProductos
@buscar varchar(50) = ''  
  
as  
begin 
	select
		p.IdProducto,
		c.IdCategoria,
		c.Nombre as NombreCategoria ,
		p.Codigo,
		p.Descripcion,
		p.PrecioCompra,
		p.PrecioVenta,
		p.Cantidad,
		p.Activo
	from Productos p
	inner join Categorias c on c.IdCategoria = p.IdCategoria
	where 
	CONCAT(p.Codigo,p.Descripcion,c.Nombre,iif(p.activo =1,'SI','NO'))
	like '%' + @Buscar + '%'  
end  
go

--sp_help producto
  
create procedure sp_crearProducto
@IdCategoria int,
@Codigo varchar(50),
@Descripcion varchar(150),
@PrecioCompra decimal(10,2),
@PrecioVenta decimal(10,2),
@Cantidad int
  
as  
begin  
	if(exists(select * from Productos where Descripcion = @Descripcion))  
	begin
		return 0 --ya existe	
	end

	insert into Productos(IdCategoria,Codigo,Descripcion,PrecioCompra,PrecioVenta,Cantidad)  
	values(@IdCategoria,@Codigo,@Descripcion,@PrecioCompra,@PrecioVenta,@Cantidad) 
	return 1 --agregado con exito  
end
go  
  
create procedure sp_editarProducto  
@IdProducto int,  
@IdCategoria int,
@Codigo varchar(50),
@Descripcion varchar(150),
@PrecioCompra decimal(10,2),
@PrecioVenta decimal(10,2),
@Cantidad int,  
@Activo int 
 
as  
begin    
	if(exists(select * from Productos where Descripcion = @Descripcion  
	and IdProducto != @IdProducto ))  
	begin  
		return 0  --ya existe
	end  
  
	update Productos set  
		IdCategoria = @IdCategoria,
		Codigo= @Codigo,
		Descripcion = @Descripcion,
		PrecioCompra = @PrecioCompra,
		PrecioVenta = @PrecioVenta,
		Cantidad = @Cantidad,
		Activo = @Activo  
	where IdProducto = @IdProducto  
	return 1 --modificado con exito
end


------USUARIOS-------
insert into Roles(Nombre) values
('Administrador'),
('Ventas')


insert into Usuarios(IdRol,NombreCompleto,Correo,NombreUsuario,Clave,ImagenUsuario,ResetearClave) values
(1,'Mauro Duran','admin@gmail.com','admin',
'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',null,0)
go


--procedimientos rol
create procedure sp_listarRoles
as
begin
	select IdRol,Nombre from Roles
end
go
--exec sp_listaRol

--procedimientos usuario

--sp_helptext 'sp_listaCategoria'

  
create procedure sp_listarUsuarios
@Buscar varchar(50) = ''  

as  
begin  
	select
		u.IdUsuario,
		r.IdRol,
		r.Nombre[NombreRol],
		u.NombreCompleto,
		u.Correo,
		u.NombreUsuario,
		u.ImagenUsuario,
		u.Activo
	from  Usuarios u
	inner join Roles r on r.IdRol = u.IdRol
	where concat(r.Nombre,u.NombreCompleto,u.Correo,u.NombreUsuario,
	iif(u.activo =1 ,'SI','NO'))   
	like '%' + @Buscar + '%'  
end
go 
  
CREATE procedure sp_crearUsuario
@IdRol int,
@NombreCompleto varchar(50),
@Correo varchar(50),
@NombreUsuario varchar(50),
@Clave varchar(100),
@ImagenUsuario VARBINARY(MAX)
as  
begin  
	if(exists(select * from Usuarios where Correo = @Correo or NombreUsuario = @NombreUsuario))  
	begin
		return 0 --ya existe
	end 
	
	INSERT INTO Usuarios(IdRol, NombreCompleto, Correo, NombreUsuario, Clave, ImagenUsuario)  
    VALUES(@IdRol, @NombreCompleto, @Correo, @NombreUsuario, @Clave, @ImagenUsuario)  
	return 1 --agregado con exito
end
go

alter procedure sp_editarUsuario
@IdUsuario int,
@IdRol int,
@NombreCompleto varchar(50),
@Correo varchar(50),
@NombreUsuario varchar(50),
@ImagenUsuario VARBINARY(MAX),
@Activo int

as  
begin  
	if(exists(select * from Usuarios where Correo = @Correo	and IdUsuario != @IdUsuario))  
	begin  	
		return 0 --ya existe correo
	end  
	if(exists(select * from Usuarios where NombreUsuario = @NombreUsuario and IdUsuario != @IdUsuario))  
	begin  	
		return 1 --ya existe usuario
	end  
   update Usuarios set
	  IdRol = @IdRol,
	  NombreCompleto = @NombreCompleto,
	  Correo = @Correo,
	  NombreUsuario = @NombreUsuario,
	  ImagenUsuario = @ImagenUsuario,
	  Activo = @Activo	  
   where IdUsuario = @IdUsuario
   return 2 --editado con exito
end