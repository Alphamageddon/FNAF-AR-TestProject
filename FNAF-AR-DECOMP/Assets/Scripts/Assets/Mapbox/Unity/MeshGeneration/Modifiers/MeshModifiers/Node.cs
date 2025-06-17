using UnityEngine;

namespace Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Node
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int i;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float x;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float y;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int mZOrder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node prev;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node next;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node prevZ;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node nextZ;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool steiner;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Node(int ind, float pX, float pY)
        {
            this.i = ind;
            this.x = pX;
            this.y = pY;
            mem[1152921526246860012] = 0;
            this.mZOrder = 0;
            this.prev = null;
            mem[1152921526246860028] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void setPreviousNode(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node pNode)
        {
            this.prev = pNode;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node getPreviousNode()
        {
            return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)this.prev;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void setNextNode(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node pNode)
        {
            this.next = pNode;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node getNextNode()
        {
            return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)this.next;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void setZOrder(int pZOrder)
        {
            this.mZOrder = pZOrder;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected int getZOrder()
        {
            return (int)this.mZOrder;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void setPreviousZNode(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node pNode)
        {
            this.prevZ = pNode;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node getPreviousZNode()
        {
            return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)this.prevZ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void setNextZNode(Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node pNode)
        {
            this.nextZ = pNode;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node getNextZNode()
        {
            return (Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.Node)this.nextZ;
        }
    
    }

}
