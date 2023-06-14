-- user_login----------------------------------------------------------------------------

CREATE TABLE user_login (
  username VARCHAR2(50),
  password VARCHAR2(50)
);

insert into user_login values ('test', 'test');

SELECT * FROM user_login;

SELECT COUNT(*) FROM user_login WHERE username = 'lucky' AND password = '1234'


----------------------------------------- dashboard -----------------------------------------

CREATE TABLE food_inventory (
  item_id     NUMBER,
  item_name   VARCHAR2(100),
  quantity    NUMBER,
  price       NUMBER,
  expiration_date DATE
);


CREATE OR REPLACE PROCEDURE add_food_item(
  p_item_id     NUMBER,
  p_item_name   VARCHAR2,
  p_quantity    NUMBER,
  p_price       NUMBER,
  p_expiration_date DATE
) AS
BEGIN
  INSERT INTO food_inventory (item_id, item_name, quantity, price, expiration_date)
  VALUES (p_item_id, p_item_name, p_quantity, p_price, p_expiration_date);
  COMMIT;
  DBMS_OUTPUT.PUT_LINE('Food item added successfully.');
EXCEPTION
  WHEN OTHERS THEN
    DBMS_OUTPUT.PUT_LINE('Error: Unable to add food item.');
END;
