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

----------------------------------------------------------------- update

CREATE OR REPLACE PROCEDURE update_inventory(
  p_item_id   NUMBER,
  p_quantity  NUMBER
) AS
BEGIN
  UPDATE food_inventory
  SET quantity = quantity - p_quantity
  WHERE item_id = p_item_id;
  COMMIT;
  DBMS_OUTPUT.PUT_LINE('Inventory updated successfully.');
EXCEPTION
  WHEN NO_DATA_FOUND THEN
    DBMS_OUTPUT.PUT_LINE('Error: Food item not found.');
  WHEN OTHERS THEN
    DBMS_OUTPUT.PUT_LINE('Error: Unable to update inventory.');
END;
/

------------------------------------------------------------------display

CREATE OR REPLACE PROCEDURE display_inventory AS
BEGIN
  FOR item IN (SELECT item_id, item_name, quantity, price, expiration_date FROM food_inventory) LOOP
    DBMS_OUTPUT.PUT_LINE('Item ID: ' || item.item_id);
    DBMS_OUTPUT.PUT_LINE('Item Name: ' || item.item_name);
    DBMS_OUTPUT.PUT_LINE('Quantity: ' || item.quantity);
    DBMS_OUTPUT.PUT_LINE('Price: ' || item.price);
    DBMS_OUTPUT.PUT_LINE('Expiration Date: ' || TO_CHAR(item.expiration_date, 'DD-MON-YYYY'));
    DBMS_OUTPUT.PUT_LINE('------------------------');
  END LOOP;
EXCEPTION
  WHEN OTHERS THEN
    DBMS_OUTPUT.PUT_LINE('Error: Unable to display inventory.');
END;
/

------------------------------------------------------------------ recipe add

CREATE TABLE recipe (
  recipe_id     NUMBER,
  recipe_name   VARCHAR2(100),
  notes			varchar2(200),
  recipe_cost   NUMBER
  
);



CREATE OR REPLACE PROCEDURE add_recipe(
  r_id     NUMBER,
  r_name   VARCHAR2,
  r_note   varchar2,
  r_cost       NUMBER

) AS
BEGIN
  INSERT INTO recipe ( recipe_id, recipe_name,notes,recipe_cost )
  VALUES (r_id, r_name, r_note, r_cost);
  COMMIT;
  DBMS_OUTPUT.PUT_LINE('Food item added successfully.');
EXCEPTION
  WHEN OTHERS THEN
    DBMS_OUTPUT.PUT_LINE('Error: Unable to add food item.');
END;



--//////////////////////////////////////////////////////////////////////////////// testing 

BEGIN

Add_food_item (1,'apple',10,100,TO_DATE('2023-06-30','YYYY-MM-DD'));

END;

GRANT EXECUTE ON sys.add_food_item TO system;



