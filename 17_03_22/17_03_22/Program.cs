using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_22
{
    class Program
    {

        // 힙 sort  최상위 노드를 추출해서 배열에 담으면 정렬됨.
        class Treesort
        {
            int count;
            int[] buffer;
            int last;

            public Treesort()
            {
                buffer = new int[100];
                last = -1;
            }
            public void insert(int val)
            {
                buffer[++last] = val;

                if(last > 0)
                {
                    int curIndex = last;
                    int parentIndex = (last - 1) / 2;

                    while(buffer[curIndex] > buffer[parentIndex])
                    {
                        int tmp = buffer[curIndex];
                        buffer[curIndex] = buffer[parentIndex];
                        buffer[parentIndex] = tmp;

                        if (parentIndex != 0)
                        { 
                            // 위에 있는 부모와 확인 작업..
                            curIndex = parentIndex;
                            parentIndex = (parentIndex - 1) / 2;
                        }
                        else
                            break;
                    }
                }
            }

            public int Delete()
            {
                if(last < 0)
                {
                    return 0;
                }
                else
                {
                    int returnval = buffer[0];
                    buffer[0] = buffer[last ++];

                    int curIndex = 0;
                    int leftchildindex = curIndex * 2 + 1; // 왼쪽 
                    int rightchildindex = leftchildindex + 1; // 오른쪽

                    while(leftchildindex <= last) 
                    {
                        if(rightchildindex <= last)
                        {
                            if(buffer[curIndex] < buffer[leftchildindex])
                            {
                                if (buffer[leftchildindex] < buffer[rightchildindex])
                                {
                                    int tmp = buffer[curIndex]; // buffer[0]
                                    buffer[curIndex] = buffer[rightchildindex];
                                    buffer[rightchildindex] = tmp;

                                    curIndex = rightchildindex;
                                    leftchildindex = curIndex * 2 + 1;
                                    rightchildindex = leftchildindex + 1;
                                }
                                else
                                {
                                    int tmp = buffer[curIndex];
                                    buffer[curIndex] = buffer[leftchildindex];
                                    buffer[leftchildindex] = tmp;

                                    curIndex = leftchildindex;
                                    leftchildindex = curIndex * 2 + 1;
                                    rightchildindex = leftchildindex + 1;
                                }
                            }

                            else if (buffer[curIndex] < buffer[rightchildindex])
                            {

                                int tmp = buffer[curIndex];
                                buffer[curIndex] = buffer[rightchildindex];
                                buffer[rightchildindex] = tmp;

                                curIndex = rightchildindex;
                                leftchildindex = curIndex * 2 + 1;
                                rightchildindex = leftchildindex + 1;

                            }
                            else
                                break;
                        }
                        else
                        {
                            if (buffer[curIndex] < buffer[leftchildindex])
                            {
                                int tmp = buffer[curIndex];
                                buffer[curIndex] = buffer[leftchildindex];
                                buffer[leftchildindex] = tmp;
                            }
                            break;
                        }
                    }
                    return returnval;
                }
     
            }
            
        }
        static void Main(string[] args)
        {
            Treesort sort = new Treesort();

            sort.insert(4);
            sort.insert(81);
            sort.insert(12);
            sort.insert(45);
            sort.insert(32);
            sort.insert(64);
            sort.insert(76);

            sort.Delete();
            sort.Delete();
            sort.Delete();
            sort.Delete();
            sort.Delete();
            sort.Delete();

        }
    }
}
