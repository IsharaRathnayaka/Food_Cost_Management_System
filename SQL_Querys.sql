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
  DBMS_OUTPUT.PUT_LINE('recipe item added successfully.');
EXCEPTION
  WHEN OTHERS THEN
    DBMS_OUTPUT.PUT_LINE('Error: Unable to add recipe item.');
END;

-- //////////////////////////////////////////////////////////////////////////////// add supplier 

CREATE TABLE supplier (
  supplier_id     NUMBER,
  supplier_name   VARCHAR2(100),
  supplier_mobile	NUMBER,
  supplier_items    VARCHAR2(200)
  
);



CREATE OR REPLACE PROCEDURE add_supplier(
  s_id     NUMBER,
  s_name   VARCHAR2,
  s_mobile NUMBER, 
  s_items  VARCHAR2

) AS
BEGIN
  INSERT INTO supplier ( supplier_id, supplier_name, supplier_mobile,  supplier_items)
  VALUES (s_id, s_name, s_mobile, s_items);
  COMMIT;
  DBMS_OUTPUT.PUT_LINE('supplier added successfully.');
EXCEPTION
  WHEN OTHERS THEN
    DBMS_OUTPUT.PUT_LINE('Error: Unable to add supplier.');
END;

-- ////////////////////////////////////////////////////////////////////////////// add total cost 

CREATE TABLE daily_cost (
  total_cost     NUMBER,
  marked_date	 DATE 
);

CREATE OR REPLACE PROCEDURE add_daily_cost(
  totcost     NUMBER,
  mdate DATE
) AS
BEGIN
  INSERT INTO daily_cost (total_cost, marked_date)
  VALUES (totcost, mdate);
  COMMIT;
  DBMS_OUTPUT.PUT_LINE('cost added successfully.');
EXCEPTION
  WHEN OTHERS THEN
    DBMS_OUTPUT.PUT_LINE('Error: Unable to add this cost.');
END;

-- ////////////////////////////////////////////////////////////////////////////// carete primary and forging keys

ALTER TABLE supplier
ADD CONSTRAINT pk_supplier PRIMARY KEY (supplier_id);


ALTER TABLE food_inventory
ADD CONSTRAINT fk_food_supplier
FOREIGN KEY (item_id)
REFERENCES supplier (supplier_id);

COMMIT;

-- /////////////////////////////////////////////////////////////////////////////////// cursor for supplier

DECLARE
  CURSOR supplier_cursor IS
    SELECT supplier_id, supplier_name, supplier_mobile, supplier_items
    FROM supplier;
    
  v_supplier_id supplier.supplier_id%TYPE;
  v_supplier_name supplier.supplier_name%TYPE;
  v_supplier_mobile supplier.supplier_mobile%TYPE;
  v_supplier_items supplier.supplier_items%TYPE;
BEGIN
  OPEN supplier_cursor;
  
  LOOP
    FETCH supplier_cursor INTO v_supplier_id, v_supplier_name, v_supplier_mobile, v_supplier_items;
    EXIT WHEN supplier_cursor%NOTFOUND;
    
    
    DBMS_OUTPUT.PUT_LINE('Supplier ID: ' || v_supplier_id);
    DBMS_OUTPUT.PUT_LINE('Supplier Name: ' || v_supplier_name);
    DBMS_OUTPUT.PUT_LINE('Supplier Mobile: ' || v_supplier_mobile);
    DBMS_OUTPUT.PUT_LINE('Supplier Items: ' || v_supplier_items);
    DBMS_OUTPUT.PUT_LINE('--------------------------');
  END LOOP;
  
  CLOSE supplier_cursor;
END;

-- //////////////////////////////////////////////////////////////////////////////////// cursor for recipe

DECLARE
  CURSOR recipe_cursor IS
    SELECT recipe_id, recipe_name, notes, recipe_cost
    FROM recipe;
    
  v_recipe_id recipe.recipe_id%TYPE;
  v_recipe_name recipe.recipe_name%TYPE;
  v_notes recipe.notes%TYPE;
  v_recipe_cost recipe.recipe_cost%TYPE;
BEGIN
  OPEN recipe_cursor;
  
  LOOP
    FETCH recipe_cursor INTO v_recipe_id, v_recipe_name, v_notes, v_recipe_cost;
    EXIT WHEN recipe_cursor%NOTFOUND;
    
    DBMS_OUTPUT.PUT_LINE('Recipe ID: ' || v_recipe_id);
    DBMS_OUTPUT.PUT_LINE('Recipe Name: ' || v_recipe_name);
    DBMS_OUTPUT.PUT_LINE('Notes: ' || v_notes);
    DBMS_OUTPUT.PUT_LINE('Recipe Cost: ' || v_recipe_cost);
    DBMS_OUTPUT.PUT_LINE('--------------------------');
  END LOOP;
  
  CLOSE recipe_cursor;
END;


--//////////////////////////////////////////////////////////////////////////////// testing 

BEGIN

Add_food_item (1,'apple',10,100,TO_DATE('2023-06-30','YYYY-MM-DD'));

add_supplier(2, 'kumara' , 0715123098 , 'chicken meatballs');

Add_food_item (4,'Mango',20,50,TO_DATE('2023-07-30','YYYY-MM-DD'));

Add_food_item (5,'Pineapple',60,90,TO_DATE('2023-07-20','YYYY-MM-DD'));

Add_food_item (6,'Baking powder',50,100,TO_DATE('2023-12-20','YYYY-MM-DD'));

Add_food_item (7,'Chocolate chips',10,500,TO_DATE('2023-08-20','YYYY-MM-DD'));

Add_food_item (8,'Ketchup',40,200,TO_DATE('2023-09-20','YYYY-MM-DD'));

Add_food_item (9,'Cheese',70,600,TO_DATE('2023-12-20','YYYY-MM-DD'));

Add_food_item (10,'Eggs',100,300,TO_DATE('2023-07-20','YYYY-MM-DD'));

Add_food_item (11,'Cooking oil',200,700,TO_DATE('2023-08-20','YYYY-MM-DD'));

Add_food_item (12,'Rice',300,2500,TO_DATE('2023-09-20','YYYY-MM-DD'));

END;

select * from food_inventory;

GRANT EXECUTE ON sys.add_daily_cost TO system;

GRANT EXECUTE ON sys.add_food_item TO system;

GRANT EXECUTE ON sys.add_recipe TO system;

GRANT DELETE ON sys.recipe TO system;

GRANT EXECUTE ON sys.add_supplier TO system;

GRANT SELECT, INSERT, UPDATE,DELETE ON supplier TO system;

GRANT SELECT, INSERT, UPDATE,DELETE ON daily_cost TO system;




