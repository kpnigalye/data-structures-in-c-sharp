using System;

public class Node {
  private int data;
  private Node left, right;

  public Node(int data) {
    this.data = data;
  }

  public void Insert(int data) {
    if (data < this.data) {
      if (left == null) {
        left = new Node(data);
      } else {
        left.Insert(data);
      }
    } else {
      if (right == null) {
        right = new Node(data);
      } else {
        right.Insert(data);
      }
    }
  }

  public bool Contains(int data) {
    if (this.data == data) {
      return true;
    }

    if (data < left.data) {
      if (left == null) {
        return false;
      } else {
        return left.Contains(data);
      }
    } else {
      if (right == null) {
        return false;
      } else {
        return right.Contains(data);
      }
    }
  }

  // left -> root -> right
  public void PrintInOrder() {
    if (left != null) {
      left.PrintInOrder();
    }

    Console.WriteLine(this.data);

    if (right != null) {
      right.PrintInOrder();
    }
  }

  // root -> left -> right
  public void PrintPreOrder() {
    Console.WriteLine(this.data);

    if (left != null) {
      left.PrintPreOrder();
    }

    if (right != null) {
      right.PrintPreOrder();
    }
  }

  // left -> right -> root 
  public void PrintPostOrder() {
    if (left != null) {
      left.PrintPostOrder();
    }

    if (right != null) {
      right.PrintPostOrder();
    }

    Console.WriteLine(this.data);
  }
}

public class MainClass {
  public static void Main(string[] args) {
    Node root = new Node(5);
    root.Insert(3);
    root.Insert(4);
    root.Insert(2);
    root.Insert(7);
    root.Insert(8);
    root.Insert(6);

    Console.WriteLine("\nInorder Traversal");
    root.PrintInOrder();

    Console.WriteLine("\nPreorder Traversal");
    root.PrintPreOrder();

    Console.WriteLine("\nPostorder Traversal");
    root.PrintPostOrder();
  }
}
