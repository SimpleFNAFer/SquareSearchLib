�������:

�����������, ��� � �� ������� 3 �������: 
-product (�������� ������� id � name), 
-category (��������  ������� id � title),
-product_category (�������� ������� product_id category_id)

����� ��������� ������:

SELECT product.name, category.title
FROM product
LEFT JOIN product_category ON product_category.product_id = product.id
LEFT JOIN category ON category.id = product_category.category_id