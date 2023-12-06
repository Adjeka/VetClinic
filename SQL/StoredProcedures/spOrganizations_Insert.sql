create procedure spOrganizations_Insert(
	inout p_id int, 
	p_name varchar(100),
	p_inn numeric(12), 
	p_kpp numeric(9), 
	p_city varchar(40), 
	p_street varchar(50), 
	p_house_number int,
	p_id_organization_type int, 
	p_id_organization_attribute int,
	p_id_location int
)
as $$ 
begin 
	insert into Organizations 
	(name, inn, kpp, city, street, house_number, id_organization_type, id_organization_attribute, id_location)
	values 
	(p_name, p_inn, p_kpp, p_city, p_street, p_house_number, p_id_organization_type, p_id_organization_attribute, p_id_location)
	returning id into p_id;
end; 
$$ language plpgsql; 