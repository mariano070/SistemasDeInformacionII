/*
               File: PSEG102
        Description: Control de acceso a ABM de Usuarios
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:45.30
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
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
   public class pseg102 : GXProcedure
   {
      public pseg102( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pseg102( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUARIO )
      {
         this.AV8USUARIO = aP0_USUARIO;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV8USUARIO;
      }

      public String executeUdp( )
      {
         this.AV8USUARIO = aP0_USUARIO;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV8USUARIO;
         return AV8USUARIO ;
      }

      public void executeSubmit( ref String aP0_USUARIO )
      {
         pseg102 objpseg102;
         objpseg102 = new pseg102();
         objpseg102.AV8USUARIO = aP0_USUARIO;
         objpseg102.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpseg102.executePrivateCatch ));
         aP0_USUARIO=this.AV8USUARIO;
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
         AV9permiso = 0 ;
         if ( StringUtil.StrCmp(AV8USUARIO, "SUPERVISOR") == 0 )
         {
            AV9permiso = 1 ;
         }
         if ( AV9permiso == 0 )
         {
            /* Using cursor P002R2 */
            pr_default.execute(0, new Object[] {AV8USUARIO});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A40TTBUS8_CodUsuario = P002R2_A40TTBUS8_CodUsuario[0] ;
               AV9permiso = 1 ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
         }
         if ( AV9permiso == 0 )
         {
            context.wjLoc = "htbusseg2.aspx" ;
         }
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
         scmdbuf = "" ;
         P002R2_A40TTBUS8_CodUsuario = new String[] {""} ;
         A40TTBUS8_CodUsuario = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pseg102__default(),
            new Object[][] {
                new Object[] {
               P002R2_A40TTBUS8_CodUsuario
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9permiso ;
      private String AV8USUARIO ;
      private String scmdbuf ;
      private String A40TTBUS8_CodUsuario ;
      private IGxDataStore dsDefault ;
      private String aP0_USUARIO ;
      private IDataStoreProvider pr_default ;
      private String[] P002R2_A40TTBUS8_CodUsuario ;
   }

   public class pseg102__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002R2 ;
          prmP002R2 = new Object[] {
          new Object[] {"@AV8USUARIO",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002R2", "SELECT [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV8USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002R2,1,0,false,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
