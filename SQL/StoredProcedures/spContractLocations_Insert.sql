create procedure spContractLocations_Insert(
	inout p_id int, 
	p_id_location int, 
	p_id_contract int, 
	p_examination_cost int
)
as $$ 
begin 
	insert into ContractLocations (id_location, id_contract, examination_cost)
	values (p_id_location, p_id_contract, p_examination_cost)
	returning id into p_id;
end; 
$$ language plpgsql; 