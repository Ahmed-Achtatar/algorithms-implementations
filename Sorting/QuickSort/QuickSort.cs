public void QuickSort(double[] tab, int first, int last ) 
        {
            
            int nbr = tab.Length;
            var arr = new double[nbr];
            int pivot, left, right;
            double tmp;

            if(first < last)
            {
                pivot = first;
                left = first;
                right = last;
                
                while (left < right)
                {
                    while ((arr[left] <= arr[pivot]) && (left < last))
                        left++;
                    while (arr[right] > arr[pivot])
                        right--; 
                    if(left < right)
                    {
                        tmp = arr[left];
                        arr[right] = arr[right];
                        arr[right] = tmp;
                    }
                }
                
                tmp = arr[pivot];
                arr[pivot] = arr[right];
                arr[right] = arr[pivot];

                QuickSort(tab, first, right - 1);
                QuickSort(tab, right + 1, last);
            }
        }
