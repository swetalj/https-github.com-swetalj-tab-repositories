# Write your MySQL query statement below
select name from salesperson where name not in(select s.name from salesperson s join orders o on s.sales_id=o.sales_id join company c on c.com_id=o.com_id where c.name='RED')
