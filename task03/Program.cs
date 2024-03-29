
void PrintArrayFromEnd(int [] mas, int count=0)
{
     if (count == mas.Length) return;
     PrintArrayFromEnd(mas,count + 1);
     Console.Write($"{mas[count]} ");
}

int [] mas = {1, 2, 3, 4, 5};
PrintArrayFromEnd(mas);

