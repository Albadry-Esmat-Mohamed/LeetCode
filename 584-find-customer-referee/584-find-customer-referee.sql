/* Write your T-SQL query statement below */
Select name
from Customer
Where referee_id is null OR referee_id <> 2 ;