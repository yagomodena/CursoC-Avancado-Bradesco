namespace CursoC_Avancado
{
    public class Professor
    {
        protected readonly float salariomaximo;
        float salarioatual;

        public Professor(float salarioMaximo)
        {
            salariomaximo = salarioMaximo;
        }

        protected float ModificarSalario(float Modf)
        {
            float novoSalario = salarioatual + Modf;

            if(novoSalario < 0 )
            {
                salarioatual = 0;
            }else if( novoSalario > salariomaximo)
            {
                salarioatual = salariomaximo;
            }
            else
            {
                salarioatual = novoSalario;
            }

            return salarioatual;
        }

        public float AumentaSalario()
        {
            return ModificarSalario(+500);
        }

        public float DiminuiSalario()
        {
            return ModificarSalario(-500);
        }
    }
}
