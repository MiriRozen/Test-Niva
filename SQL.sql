/****** Script for SelectTopNRows command from SSMS  ******/
SELECT products.ProductID
      ,products.ProductDesc
	  ,COUNT(orders.OrderID) AS 'Count'
	  FROM [TestDB].[dbo].[Products] products 
  LEFT JOIN [TestDB].[dbo].[Order Details] orderDetails
  on products.ProductID = orderDetails.ProductID
  LEFT JOIN [TestDB].[dbo].[Orders]  orders 
  on orderDetails.OrderID = orders.OrderID
  group by products.ProductID, products.ProductDesc
