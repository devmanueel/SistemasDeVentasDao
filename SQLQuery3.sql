alter procedure sp_editarCategoria
@idCategoria int,
@nombre varchar(50),
@idMedida int,
@activo int
as 
begin
	if (exists (select * from Categorias where Nombre = @nombre and IdCategoria != @idCategoria))
		begin
			raiserror('La categoria no existe', 16, 1)
			return
		end
	update Categorias
	set Nombre = @nombre,
		IdMedida = @idMedida,
		Activo = @activo
	where IdCategoria = @idCategoria
end