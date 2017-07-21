public static Node findInOrderSuccessor(Node inputNode)
  {
    // your code goes here
    if(inputNode.right != null){
      inputNode = inputNode.right;
      while(inputNode.left != null)
        inputNode = inputNode.left;
      return inputNode;
    }
    else if(inputNode.value < inputNode.parent.value)
      return inputNode.parent;
    else{
      while(inputNode.parent != null && inputNode.parent.value < inputNode.value){
        inputNode = inputNode.parent;
      }
      return inputNode.parent;
    }
      
  }
