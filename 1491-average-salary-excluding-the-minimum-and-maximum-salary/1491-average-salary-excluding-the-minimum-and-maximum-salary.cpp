class Solution {
public:
    double average(vector<int>& salary) {
        
          
        int maxSalary    = 0;
        int minSalary    = 0;
        int count        = 0;
        double sum       = 0;
        
        
        for( int i = 0; i < salary.size(); i++)
        {
            
            //Min Salary
            if( i == 0  )
                minSalary = salary[i];
            else
            {
                if( salary[i] < minSalary )
                    minSalary = salary[i];
            }
            
            //Max Salary
            if( salary[i] > maxSalary )
                maxSalary = salary[i];
            
            //Count
            count++;

            //Sum
            sum = sum + salary[i];
            

        
        }
            count = count - 2;
            sum = sum - maxSalary - minSalary;
            return sum / count;
        
    }
};