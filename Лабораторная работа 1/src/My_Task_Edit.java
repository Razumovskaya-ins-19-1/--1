
import java.util.ArrayList;
import java.util.Scanner;

public class My_Task_Edit {

	private ArrayList<Double> aa = new ArrayList<Double>();
	private int N;
	
	public void InputArray()
	{
		aa.clear();
		Scanner sc = new Scanner(System.in);
		System.out.print("������� ���������� ����� > ");
		N = sc.nextInt();
		
		double a;
		for (int i=0; i<N; i++)
		{
			System.out.print("������� ����� " + String.valueOf(i+1) + " > ");
			a=sc.nextDouble();
			aa.add(a);
		}
		sc.close();
	}
	
	public void PrintResult()
	{
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
		System.out.println("����� ������������ � ���������� �� ��� ���������: ");
		for (int i=0; i<N; i++)
		{
			if (aa.get(i)<min1)
			{
				min2=min1;
				min1=aa.get(i);
			}
		}
		System.out.println(min1+min2);
	}
}
