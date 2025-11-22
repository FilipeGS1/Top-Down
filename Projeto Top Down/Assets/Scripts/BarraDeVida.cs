using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Slider sliderVidaRestantes;
   
    public Personagem personagem;
    [SerializeField] private int VidasRestantes = 0;
    
    void Start()
    {
        if (personagem != null & sliderVidaRestantes != null)
        {
            sliderVidaRestantes.minValue = 0;
            sliderVidaRestantes.maxValue = personagem.getVida();
        }
        
        
    }

    
    void Update()
    {
        if (sliderVidaRestantes != null)
        {
            VidasRestantes = personagem.getVida();
            sliderVidaRestantes.value = VidasRestantes;
        }
    }
}
