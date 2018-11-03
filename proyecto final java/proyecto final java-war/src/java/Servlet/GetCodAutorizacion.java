/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servlet;

import beans.IEJBAutorizar;
import conexion.ConexionBD;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.SQLException;
import java.util.HashMap;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.naming.InitialContext;
import javax.naming.NamingException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.ws.rs.client.Client;
import javax.ws.rs.client.ClientBuilder;
import javax.ws.rs.client.WebTarget;
import javax.ws.rs.core.MediaType;

/**
 *
 * @author Diego
 */
public class GetCodAutorizacion extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try (PrintWriter out = response.getWriter()) {
            /* TODO output your page here. You may use following sample code. */
            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Servlet GetCodAutorizacion</title>");            
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>Servlet GetCodAutorizacion at " + request.getContextPath() + "</h1>");
            out.println("</body>");
            out.println("</html>");
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html");
        PrintWriter writer = response.getWriter();
        System.out.println("hola");
        String codigo = "123456789";
        
        writer.println("<!DOCTYPE html>");
        writer.println("<html>");
        writer.println("<head>");
        writer.println("<title>Servlet HolaMundoServlet</title>");            
        writer.println("</head>");
        writer.println("<body>");
        writer.println("<h1>Bienvenido al Hospital</h1>");
        writer.println("<h3>ingrese sus datos</h3>");
        writer.println("<form action='' method='POST'>");
        writer.println("<input style='display: none;' type='text' name='CodigoHospital' value='" + codigo + "' /> <br>");
        writer.println("CodigoCliente: <input type='text' name='CodigoCliente'/>");
        writer.println("<input type='submit'/>");
        writer.println("</form>");      
        writer.println("</body>");
        writer.println("</html>");
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html");
        PrintWriter writer = response.getWriter();
        
        //obtiene los datos del weservice
        String CodigoHospital;
        String CodigoCliente;
        
        CodigoHospital = request.getParameter("CodigoHospital");
        CodigoCliente = request.getParameter("CodigoCliente");
        
        //crear cliente para el servicio web
        Client client = ClientBuilder.newClient();
        
        //set target
        WebTarget targuet = client.target("https://min-api.cryptocompare.com/data/price?fsym=BTC&tsyms=USD,JPY,EUR");
        
        //get response
        //esta linea es para probar que devuelve con res.getClass()
        //Object res = targuet.request(MediaType.APPLICATION_JSON).get(Object.class);
        HashMap res = targuet.request(MediaType.APPLICATION_JSON).get(HashMap.class);
        
        System.out.println(
                res.get("USD")
            );
        
        
        
        try {
            ConexionBD conexionBD;
            conexionBD = new ConexionBD();
            conexionBD.insertHistorial(CodigoHospital, CodigoCliente);
            
        } catch (ClassNotFoundException | SQLException ex) {
            Logger.getLogger(GetCodAutorizacion.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        
        
        
        writer.println("<!DOCTYPE html>");
        writer.println("<html>");
        writer.println("<head>");
        writer.println("<title>Servlet HolaMundoServlet</title>");            
        writer.println("</head>");
        writer.println("<body>");
        writer.println("<h1>sus datos son al servlet</h1>");
        writer.println("<h3>data</h3>");
        
        writer.println(CodigoHospital); 
        writer.println("<br>");
        writer.println(CodigoCliente);
        writer.println("</body>");
        writer.println("</html>");
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
