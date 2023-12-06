create procedure spContracts_Delete(
	p_id int
)
as $$ 
begin 
	delete from Contracts 
	where id = p_id;
end; 
$$ language plpgsql; 