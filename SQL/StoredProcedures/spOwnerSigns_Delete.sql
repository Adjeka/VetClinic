create procedure spOwnerSigns_Delete(
	p_id int
)
as $$ 
begin 
	delete from OwnerSigns
	where id = p_id;
end; 
$$ language plpgsql; 