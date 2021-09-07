import java.util.ArrayList;
import java.util.Scanner;

public class My_Task {

	public static void DoTask()
	{
		Scanner sc = new Scanner(System.in);
		System.out.print("¬ведите количество чисел > ");
		int N = sc.nextInt();
		
		double a;
		ArrayList<Double> aa = new ArrayList();
		
		for(int i=0; i<N; i++)
		{
			System.out.print("¬ведите число "+ String.valueOf(i+1) + " > ");
			 a=sc.nextDouble();
			    aa.add(a);
		}
		double  min1 = aa.get(0);
		double min2 = aa.get(1);
		if(min1==min2)
		{
			int i =2;
			while(min1==min2)
			{
				min2=aa.get(i);
				i++;
			}
		}
		System.out.println("—умма минимального и следующего за ним элементов: ");
		for (int i=0; i<N; i++)
		{
			if (aa.get(i)<min1)
			{
				min2=min1;
				min1=aa.get(i);
			}
		}
		System.out.println(min1+min2);
		sc.close();
	}
}
