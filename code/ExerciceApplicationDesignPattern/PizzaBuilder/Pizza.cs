//The base product 
public class Pizza {
    public string typeDough = "";
    public string typeBase = "";
    public string toppers = "";

    public void setTypeDough(string typeDough){
        this.typeDough = typeDough;
    }

    public void setTypeBase(string typeBase) {
        this.typeBase = typeBase;
    }

    public void setToppers(string toppers) {
        this.toppers = toppers;
    }
    
	public string toString() {
		return "Pizza [dough=" + this.typeDough + ", sauce=" + this.typeBase + ", contenu=" + this.toppers + "]";
	}
}