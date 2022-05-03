
-- Create trigger for column auto update updated_at

create trigger units_update on units for update as
begin
  update units
	set updated_at = CURRENT_TIMESTAMP
end

go

create trigger users_update on users for update as
begin
  update users
	set updated_at = CURRENT_TIMESTAMP
end

go

create trigger roles_update on roles for update as
begin
  update roles
	set updated_at = CURRENT_TIMESTAMP
end

go

create trigger products_update on products for update as
begin
  update products
	set updated_at = CURRENT_TIMESTAMP
end

go

create trigger categories_update on categories for update as
begin
  update categories
	set updated_at = CURRENT_TIMESTAMP
end

go

create trigger product_ratings_update on product_ratings for update as
begin
  update product_ratings
	set updated_at = CURRENT_TIMESTAMP
end

go

create trigger carts_update on carts for update as
begin
  update carts
	set updated_at = CURRENT_TIMESTAMP
end

go

create trigger orders_update on orders for update as
begin
  update orders
	set updated_at = CURRENT_TIMESTAMP
end

go

create trigger order_details_update on order_details for update as
begin
  update order_details
	set updated_at = CURRENT_TIMESTAMP
end

go

create trigger distributors_update on distributors for update as
begin
  update distributors
	set updated_at = CURRENT_TIMESTAMP
end

go

create trigger shipments_update on shipments for update as
begin
  update shipments
	set updated_at = CURRENT_TIMESTAMP
end

go

create trigger shipment_details_update on shipment_details for update as
begin
  update shipment_details
	set updated_at = CURRENT_TIMESTAMP
end

go