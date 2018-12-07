import java.util.Scanner;

public class RectangleCalculatorApp {

	public static void main(String[] args) {
		System.out.println("Welcome to the Rectangle Calculator App");
		System.out.println();
		
		Scanner sc = new Scanner(System.in);
		
		String choice = "y";
		while (choice.equalsIgnoreCase("y")) {
			System.out.print("Enter length: ");
			double length = sc.nextDouble();
			System.out.print("Enter width: ");
			double width = sc.nextDouble();
			System.out.println("Area: " + width * length);
			System.out.println("Perimeter: " + (2 * width + 2 * length));
			System.out.println();
			
			System.out.print("Continue?: (y/n)");
			System.out.println();
			choice = sc.next();
			
		}

	}

}
