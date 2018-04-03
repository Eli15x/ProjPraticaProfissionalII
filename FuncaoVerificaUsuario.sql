

Create function VerificaUsuario(@senha varchar(30), @NomeUsuario varchar(30))
Returns bit

as

begin
	
	declare @ret bit;

	set @ret = 0;
	
	if(@senha = (select senha from Usuario where nomeUsuario = @NomeUsuario))
		set @ret = 1;
	
	return @ret;

end	 


