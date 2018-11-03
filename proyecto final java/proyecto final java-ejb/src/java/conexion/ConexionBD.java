/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package conexion;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.util.Date;

/**
 *
 * @author Diego
 */
public class ConexionBD {
    
    public static String url = "jdbc:sqlserver://DIEGOLENOVO:1433;databaseName=proveedor";
    public static String usuario = "usuario_java";
    public static String pass = "123456";
    public static Connection con;
    
    ConexionBD() {
        try{
            //cargar driver
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
                        
            //conectar a base de datos
            con = DriverManager.getConnection(url, usuario, pass);
            
            /** test de conexion
            Statement sentencia = con.createStatement();
            
            ResultSet rs = sentencia.executeQuery("select * from historial_codigos");
            
            
            //obtener datos
            while (rs.next()) {
                System.out.println(rs.getString("cod_cliente"));
            }
            */
            
            
        } catch (ClassNotFoundException | SQLException ex) {
            System.out.println(ex);
        }
    }
    
    public static void main(String[] args) {
        ConexionBD conexionBD = new ConexionBD();
        
        //conexionBD.insertHistorial("cod112", "cliet1215");
    }
    
    public void insertHistorial (String cod_autorizacion, String cod_cliente) {
        try{
            Statement sentencia = con.createStatement();

            Date fecha = new Date();
            String fecha_consulta = new SimpleDateFormat("yyyy-MM-dd").format(fecha);

            PreparedStatement stmt = con.prepareStatement("INSERT INTO historial_codigos VALUES (?,?,?)");

            stmt.setString(1, cod_autorizacion);
            stmt.setString(2, cod_cliente);
            stmt.setString(3, fecha_consulta);

            stmt.executeUpdate();
            
        } catch ( SQLException ex) {
            System.out.println(ex);
        }
    }
    
}
