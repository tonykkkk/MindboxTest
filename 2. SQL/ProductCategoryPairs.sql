SELECT
	Products.ProductName,
	Categories.CategoryName
FROM
    Products
    left JOIN ProductCategories ON products.ProductID = ProductCategories.ProductID
	left join Categories on ProductCategories.CategoryID = Categories.CategoryID