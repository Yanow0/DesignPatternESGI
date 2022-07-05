using System.Collections.Generic;

public class Vendeur
{
  private static Vendeur _instance = null;

  private Vendeur()
  {
  }

  public static Vendeur Instance()
  {
    if (_instance == null)
      _instance = new Vendeur();
    return _instance;
  }

public void construitBonDeCommande(string nomClient)
    {
        LiasseClient laLiasseClient = new LiasseClient(nomClient);
        laLiasseClient.imprime();
    }
}
