/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    
    
    private int[] array;
    private int index;
    
    public IntegerList(){
        array = new int[5];
        index = -1;
        
    }
    
    public void add(int item){
        index++;
        
        if(index < array.Length)
        {
            array[index] = item;
        }
        else{
            index--;
            
        }
        
    }
    
    // Tasks Modify this code.
    
    public void insert(int index, int item){
        
        if(index > -1 && index <= this.index)
        {
            for(int i = 0; this.index; i >= index; i--){
                array[i+1] = array[i];
            }
            
            array[index] = item;
            this.index++;
        }
        else
        {
            throw new Exception ("Index out of Range.");
        }
        
        
    }
    
    public void removeAt(int index){
        
    }
    
    public void Sort(){
        
    }
    
    public int Search(int item){
        
    }
    
    public int GetArray()
    {
        int[] tempArray = new int[index + 1];
        
        for(int i = 0; i < tempArray.Length; i++){
            
            tempArray[i] = array[i];
        }
        return tempArray;
    }
    
    public void BinarySearch(){
        
    }
    
    public void IncreaseSize(){
        int[] newArray = new int[array.Length * 2];
        //copy all elements from old array to new array.
        for(int i = 0; i < array.Length; i++){
            
            newArray[i] = array[i];
            
        }
    }
    
    
    
    
  }
}