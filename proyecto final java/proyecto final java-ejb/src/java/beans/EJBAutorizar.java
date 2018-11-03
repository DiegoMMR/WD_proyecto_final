/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package beans;
import javax.ejb.Stateless;
/**
 *
 * @author Diego
 */
@Stateless
public class EJBAutorizar implements IEJBAutorizar {
    @Override
    public String getCodAutorizacion(String CodAutorizacion) {
         return "Hola " + CodAutorizacion + " desde un bean de sesion";
    }
}
