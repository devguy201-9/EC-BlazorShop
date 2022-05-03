-- Create table for database
use vegetable

DROP TABLE IF EXISTS [users];
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
  [role_id] int NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

DROP TABLE IF EXISTS [roles];
CREATE TABLE roles (
  [id] int NOT NULL IDENTITY(1,1),
  [role_name] varchar(255) NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

DROP TABLE IF EXISTS [products];
CREATE TABLE products (
  [id] int NOT NULL IDENTITY(1,1),
  [product_code] varchar(255) NOT NULL,
  [name] varchar(255) NOT NULL,
  [description] TEXT,
  [price] float NOT NULL,
  [quantity] int NOT NULL,
  [images] nvarchar(max) NOT NULL,
  [category_id] int NOT NULL,
  [unit_id] int NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

DROP TABLE IF EXISTS [categories];
CREATE TABLE categories (
  [id] int NOT NULL IDENTITY(1,1),
  [name] varchar(255) NOT NULL,
  [description] TEXT,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

DROP TABLE IF EXISTS [product_ratings];
CREATE TABLE product_ratings (
  [user_id] int NOT NULL,
  [product_id] int NOT NULL,
  [comment] TEXT,
  [point] float DEFAULT '0',
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([user_id],[product_id])
) ;

DROP TABLE IF EXISTS [units];
CREATE TABLE units (
  [id] int NOT NULL IDENTITY(1,1),
  [name] varchar(255) NOT NULL,
  [desciption] TEXT,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

DROP TABLE IF EXISTS [carts];
CREATE TABLE carts (
  [user_id] int NOT NULL,
  [product_id] int NOT NULL,
  [quantity] int NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([user_id],[product_id])
) ;

DROP TABLE IF EXISTS [orders];
CREATE TABLE orders (
  [id] int NOT NULL IDENTITY(1,1),
  [user_id] int NOT NULL,
  [note] TEXT,
  [total_price] float NOT NULL,
  [state] varchar(12) NOT NULL CHECK (state IN('pending','processing','completed','cancelled','returned')),
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

DROP TABLE IF EXISTS [order_details];
CREATE TABLE order_details (
  [order_id] int NOT NULL,
  [product_id] int NOT NULL,
  [price] float NOT NULL,
  [quantity] int NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([order_id],[product_id])
) ;

DROP TABLE IF EXISTS [distributors];
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

DROP TABLE IF EXISTS [shipments];
CREATE TABLE shipments (
  [id] int NOT NULL IDENTITY(1,1),
  [shipment_code] varchar(255) NOT NULL,
  [distributor_id] int NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([id])
) ;

DROP TABLE IF EXISTS [shipment_details];
CREATE TABLE shipment_details (
  [shipment_id] int NOT NULL,
  [product_id] int NOT NULL,
  [purchase_price] float NOT NULL,
  [price] float NOT NULL,
  [quantity_sold] int NOT NULL,
  [current_quantity] int NOT NULL,
  [quantity] int NOT NULL,
  [status] int NOT NULL DEFAULT '1',
  [created_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  [updated_at] DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ([shipment_id],[product_id])
) ;

ALTER TABLE users ADD FOREIGN KEY ([role_id]) REFERENCES roles ([id]);
ALTER TABLE products ADD FOREIGN KEY ([category_id]) REFERENCES categories ([id]);
ALTER TABLE products ADD FOREIGN KEY ([unit_id]) REFERENCES units ([id]);
ALTER TABLE product_ratings ADD FOREIGN KEY ([user_id]) REFERENCES users ([id]);
ALTER TABLE product_ratings ADD FOREIGN KEY ([product_id]) REFERENCES products ([id]);
ALTER TABLE carts ADD FOREIGN KEY ([user_id]) REFERENCES users ([id]);
ALTER TABLE carts ADD FOREIGN KEY ([product_id]) REFERENCES products ([id]);
ALTER TABLE orders ADD FOREIGN KEY ([user_id]) REFERENCES users ([id]);
ALTER TABLE order_details ADD FOREIGN KEY ([product_id]) REFERENCES products ([id]);
ALTER TABLE order_details ADD FOREIGN KEY ([order_id]) REFERENCES orders ([id]);
ALTER TABLE shipments ADD FOREIGN KEY ([distributor_id]) REFERENCES distributors ([id]);
ALTER TABLE shipment_details ADD FOREIGN KEY ([shipment_id]) REFERENCES shipments ([id]);
ALTER TABLE shipment_details ADD FOREIGN KEY ([product_id]) REFERENCES products ([id]);
