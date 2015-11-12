/*
               File: PREP000
        Description: BUSCA NOMBRE REPORTE WEB
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:28:56.95
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class prep000 : GXProcedure
   {
      public prep000( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Modern");
      }

      public prep000( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_NOMBRE_REPORTE ,
                           ref String aP1_TIPO )
      {
         this.AV8NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV10TIPO = aP1_TIPO;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV8NOMBRE_REPORTE;
         aP1_TIPO=this.AV10TIPO;
      }

      public String executeUdp( ref String aP0_NOMBRE_REPORTE )
      {
         this.AV8NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV10TIPO = aP1_TIPO;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV8NOMBRE_REPORTE;
         aP1_TIPO=this.AV10TIPO;
         return AV10TIPO ;
      }

      public void executeSubmit( ref String aP0_NOMBRE_REPORTE ,
                                 ref String aP1_TIPO )
      {
         prep000 objprep000;
         objprep000 = new prep000();
         objprep000.AV8NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objprep000.AV10TIPO = aP1_TIPO;
         objprep000.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objprep000.executePrivateCatch ));
         aP0_NOMBRE_REPORTE=this.AV8NOMBRE_REPORTE;
         aP1_TIPO=this.AV10TIPO;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         if ( context.FileExists( "e:\\intranet\\hinicio.asp") == 1 )
         {
            if ( ( DateTimeUtil.Month( Gx_date) < 10 ) && ( DateTimeUtil.Day( Gx_date) < 10 ) )
            {
               AV8NOMBRE_REPORTE = "E:\\INTRANET\\RPT\\" + StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 4, 0) + "0" + StringUtil.Str( (decimal)(DateTimeUtil.Month( Gx_date)), 1, 0) + "0" + StringUtil.Str( (decimal)(DateTimeUtil.Day( Gx_date)), 1, 0) + StringUtil.Substring( Gx_time, 1, 2) + StringUtil.Substring( Gx_time, 4, 2) + StringUtil.Substring( Gx_time, 7, 2) ;
            }
            else if ( ( DateTimeUtil.Month( Gx_date) < 10 ) && ( DateTimeUtil.Day( Gx_date) >= 10 ) )
            {
               AV8NOMBRE_REPORTE = "E:\\INTRANET\\RPT\\" + StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 4, 0) + "0" + StringUtil.Str( (decimal)(DateTimeUtil.Month( Gx_date)), 1, 0) + StringUtil.Str( (decimal)(DateTimeUtil.Day( Gx_date)), 2, 0) + StringUtil.Substring( Gx_time, 1, 2) + StringUtil.Substring( Gx_time, 4, 2) + StringUtil.Substring( Gx_time, 7, 2) ;
            }
            else if ( ( DateTimeUtil.Month( Gx_date) >= 10 ) && ( DateTimeUtil.Day( Gx_date) < 10 ) )
            {
               AV8NOMBRE_REPORTE = "E:\\INTRANET\\RPT\\" + StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 4, 0) + StringUtil.Str( (decimal)(DateTimeUtil.Month( Gx_date)), 2, 0) + "0" + StringUtil.Str( (decimal)(DateTimeUtil.Day( Gx_date)), 1, 0) + StringUtil.Substring( Gx_time, 1, 2) + StringUtil.Substring( Gx_time, 4, 2) + StringUtil.Substring( Gx_time, 7, 2) ;
            }
            else
            {
               AV8NOMBRE_REPORTE = "E:\\INTRANET\\RPT\\" + StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 4, 0) + StringUtil.Str( (decimal)(DateTimeUtil.Month( Gx_date)), 2, 0) + StringUtil.Str( (decimal)(DateTimeUtil.Day( Gx_date)), 2, 0) + StringUtil.Substring( Gx_time, 1, 2) + StringUtil.Substring( Gx_time, 4, 2) + StringUtil.Substring( Gx_time, 7, 2) ;
            }
         }
         else
         {
            if ( ( DateTimeUtil.Month( Gx_date) < 10 ) && ( DateTimeUtil.Day( Gx_date) < 10 ) )
            {
               AV8NOMBRE_REPORTE = "c:\\inetpub\\wwwroot\\RPT\\" + StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 4, 0) + "0" + StringUtil.Str( (decimal)(DateTimeUtil.Month( Gx_date)), 1, 0) + "0" + StringUtil.Str( (decimal)(DateTimeUtil.Day( Gx_date)), 1, 0) + StringUtil.Substring( Gx_time, 1, 2) + StringUtil.Substring( Gx_time, 4, 2) + StringUtil.Substring( Gx_time, 7, 2) ;
            }
            else if ( ( DateTimeUtil.Month( Gx_date) < 10 ) && ( DateTimeUtil.Day( Gx_date) >= 10 ) )
            {
               AV8NOMBRE_REPORTE = "c:\\inetpub\\wwwroot\\RPT\\" + StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 4, 0) + "0" + StringUtil.Str( (decimal)(DateTimeUtil.Month( Gx_date)), 1, 0) + StringUtil.Str( (decimal)(DateTimeUtil.Day( Gx_date)), 2, 0) + StringUtil.Substring( Gx_time, 1, 2) + StringUtil.Substring( Gx_time, 4, 2) + StringUtil.Substring( Gx_time, 7, 2) ;
            }
            else if ( ( DateTimeUtil.Month( Gx_date) >= 10 ) && ( DateTimeUtil.Day( Gx_date) < 10 ) )
            {
               AV8NOMBRE_REPORTE = "c:\\inetpub\\wwwroot\\RPT\\" + StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 4, 0) + StringUtil.Str( (decimal)(DateTimeUtil.Month( Gx_date)), 2, 0) + "0" + StringUtil.Str( (decimal)(DateTimeUtil.Day( Gx_date)), 1, 0) + StringUtil.Substring( Gx_time, 1, 2) + StringUtil.Substring( Gx_time, 4, 2) + StringUtil.Substring( Gx_time, 7, 2) ;
            }
            else
            {
               AV8NOMBRE_REPORTE = "c:\\inetpub\\wwwroot\\RPT\\" + StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 4, 0) + StringUtil.Str( (decimal)(DateTimeUtil.Month( Gx_date)), 2, 0) + StringUtil.Str( (decimal)(DateTimeUtil.Day( Gx_date)), 2, 0) + StringUtil.Substring( Gx_time, 1, 2) + StringUtil.Substring( Gx_time, 4, 2) + StringUtil.Substring( Gx_time, 7, 2) ;
            }
         }
         AV11DIG = (short)(NumberUtil.Int( (long)(NumberUtil.Random( )*100))) ;
         if ( AV11DIG < 10 )
         {
            AV11DIG = (short)(AV11DIG+10) ;
         }
         AV8NOMBRE_REPORTE = StringUtil.Trim( AV8NOMBRE_REPORTE) + StringUtil.Str( (decimal)(AV11DIG), 2, 0) ;
         AV9OK = context.SetCookie( "REPORTE", AV8NOMBRE_REPORTE, "", (DateTime)(DateTime.MinValue), "", 0) ;
         AV9OK = context.SetCookie( "TIPO_REPORTE", AV10TIPO, "", (DateTime)(DateTime.MinValue), "", 0) ;
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         Gx_date = DateTime.MinValue ;
         Gx_time = "" ;
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short AV11DIG ;
      private short AV9OK ;
      private String AV8NOMBRE_REPORTE ;
      private String AV10TIPO ;
      private String Gx_time ;
      private DateTime Gx_date ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_TIPO ;
   }

}
