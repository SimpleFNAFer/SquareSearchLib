Решение:

Предположим, что в БД имеются 3 таблицы: 
-product (включает столбцы id и name), 
-category (включает  столбцы id и title),
-product_category (включает столбцы product_id category_id)

Тогда требуемый запрос:

SELECT product.name, category.title
FROM product
LEFT JOIN product_category ON product_category.product_id = product.id
LEFT JOIN category ON category.id = product_category.category_id