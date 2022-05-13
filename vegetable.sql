-- Create table for database
use vegetable

CREATE TABLE users (
  [id] int NOT NULL IDENTITY(1,1),
  [user_name] varchar(255) NOT NULL,
  [email] varchar(255),
  [full_name] varchar(255) NOT NULL,
  [phone_number] varchar(255),
  [address] varchar(255),
  [cmnd] varchar(100),
  [password] varchar(255) NOT NULL,
  [avatar]varchar(255),
  [rolesid] int NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

CREATE TABLE roles (
  [id] int NOT NULL IDENTITY(1,1),
  [role_name] varchar(255) NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

CREATE TABLE products (
  [id] int NOT NULL IDENTITY(1,1),
  [product_code] varchar(255) NOT NULL,
  [name] varchar(255) NOT NULL,
  [description] TEXT,
  [price] float NOT NULL,
  [quantity] int NOT NULL,
  [images] nvarchar(max) NOT NULL,
  [categorysid] int NOT NULL,
  [unitsid] int NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

CREATE TABLE categories (
  [id] int NOT NULL IDENTITY(1,1),
  [name] varchar(255) NOT NULL,
  [description] TEXT,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

CREATE TABLE product_ratings (
  [usersid] int NOT NULL,
  [productsid] int NOT NULL,
  [comment] TEXT,
  [point] float DEFAULT '0',
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([usersid],[productsid])
) ;

CREATE TABLE units (
  [id] int NOT NULL IDENTITY(1,1),
  [name] varchar(255) NOT NULL,
  [desciption] TEXT,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

CREATE TABLE carts (
  [usersid] int NOT NULL,
  [productsid] int NOT NULL,
  [quantity] int NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([usersid],[productsid])
) ;

CREATE TABLE orders (
  [id] int NOT NULL IDENTITY(1,1),
  [usersid] int NOT NULL,
  [note] TEXT,
  [total_price] float NOT NULL,
  [state] varchar(12) NOT NULL CHECK (state IN('pending','processing','completed','cancelled','returned')),
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

CREATE TABLE order_details (
  [ordersid] int NOT NULL,
  [productsid] int NOT NULL,
  [price] float NOT NULL,
  [quantity] int NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([ordersid],[productsid])
) ;

CREATE TABLE distributors (
  [id] int NOT NULL IDENTITY(1,1),
  [name] varchar(255) NOT NULL,
  [address] varchar(255) NOT NULL,
  [phone_number] varchar(100) NOT NULL,
  [email] varchar(100) NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

CREATE TABLE shipments (
  [id] int NOT NULL IDENTITY(1,1),
  [shipment_code] varchar(255) NOT NULL,
  [distributorsid] int NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

CREATE TABLE shipment_details (
  [shipmentsid] int NOT NULL,
  [productsid] int NOT NULL,
  [purchase_price] float NOT NULL,
  [price] float NOT NULL,
  [quantity_sold] int NOT NULL,
  [current_quantity] int NOT NULL,
  [quantity] int NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([shipmentsid],[productsid])
) ;

ALTER TABLE users ADD FOREIGN KEY ([rolesid]) REFERENCES roles ([id]);
ALTER TABLE products ADD FOREIGN KEY ([categorysid]) REFERENCES categories ([id]);
ALTER TABLE products ADD FOREIGN KEY ([unitsid]) REFERENCES units ([id]);
ALTER TABLE product_ratings ADD FOREIGN KEY ([usersid]) REFERENCES users ([id]);
ALTER TABLE product_ratings ADD FOREIGN KEY ([productsid]) REFERENCES products ([id]);
ALTER TABLE carts ADD FOREIGN KEY ([usersid]) REFERENCES users ([id]);
ALTER TABLE carts ADD FOREIGN KEY ([productsid]) REFERENCES products ([id]);
ALTER TABLE orders ADD FOREIGN KEY ([usersid]) REFERENCES users ([id]);
ALTER TABLE order_details ADD FOREIGN KEY ([productsid]) REFERENCES products ([id]);
ALTER TABLE order_details ADD FOREIGN KEY ([ordersid]) REFERENCES orders ([id]);
ALTER TABLE shipments ADD FOREIGN KEY ([distributorsid]) REFERENCES distributors ([id]);
ALTER TABLE shipment_details ADD FOREIGN KEY ([shipmentsid]) REFERENCES shipments ([id]);
ALTER TABLE shipment_details ADD FOREIGN KEY ([productsid]) REFERENCES products ([id]);

INSERT INTO roles (role_name) VALUES ('user');
INSERT INTO roles (role_name) VALUES ('admin');