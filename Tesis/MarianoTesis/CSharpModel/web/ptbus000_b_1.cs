/*
               File: PTBUS000_b_1
        Description: Actualiza datos baja bien de uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:8.87
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
   public class ptbus000_b_1 : GXProcedure
   {
      public ptbus000_b_1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus000_b_1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_TTBUS_Id ,
                           ref String aP1_USUARIO )
      {
         this.AV9TTBUS_Id = aP0_TTBUS_Id;
         this.AV8USUARIO = aP1_USUARIO;
         initialize();
         executePrivate();
         aP0_TTBUS_Id=this.AV9TTBUS_Id;
         aP1_USUARIO=this.AV8USUARIO;
      }

      public String executeUdp( ref int aP0_TTBUS_Id )
      {
         this.AV9TTBUS_Id = aP0_TTBUS_Id;
         this.AV8USUARIO = aP1_USUARIO;
         initialize();
         executePrivate();
         aP0_TTBUS_Id=this.AV9TTBUS_Id;
         aP1_USUARIO=this.AV8USUARIO;
         return AV8USUARIO ;
      }

      public void executeSubmit( ref int aP0_TTBUS_Id ,
                                 ref String aP1_USUARIO )
      {
         ptbus000_b_1 objptbus000_b_1;
         objptbus000_b_1 = new ptbus000_b_1();
         objptbus000_b_1.AV9TTBUS_Id = aP0_TTBUS_Id;
         objptbus000_b_1.AV8USUARIO = aP1_USUARIO;
         objptbus000_b_1.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus000_b_1.executePrivateCatch ));
         aP0_TTBUS_Id=this.AV9TTBUS_Id;
         aP1_USUARIO=this.AV8USUARIO;
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
         /* Using cursor P000D2 */
         pr_default.execute(0, new Object[] {AV9TTBUS_Id});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11TTBUS_Id = P000D2_A11TTBUS_Id[0] ;
            A195TTBUS_UsuarioBaja = P000D2_A195TTBUS_UsuarioBaja[0] ;
            n195TTBUS_UsuarioBaja = P000D2_n195TTBUS_UsuarioBaja[0] ;
            A196TTBUS_MaquinaBaja = P000D2_A196TTBUS_MaquinaBaja[0] ;
            n196TTBUS_MaquinaBaja = P000D2_n196TTBUS_MaquinaBaja[0] ;
            A23TTBUS_Estado = P000D2_A23TTBUS_Estado[0] ;
            A195TTBUS_UsuarioBaja = AV8USUARIO ;
            n195TTBUS_UsuarioBaja = false ;
            A196TTBUS_MaquinaBaja = GXUtil.WrkSt( context) ;
            n196TTBUS_MaquinaBaja = false ;
            A23TTBUS_Estado = 3 ;
            /* Using cursor P000D3 */
            pr_default.execute(1, new Object[] {n195TTBUS_UsuarioBaja, A195TTBUS_UsuarioBaja, n196TTBUS_MaquinaBaja, A196TTBUS_MaquinaBaja, A23TTBUS_Estado, A11TTBUS_Id});
            pr_default.close(1);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS000_b_1");
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
         P000D2_A11TTBUS_Id = new int[1] ;
         P000D2_A195TTBUS_UsuarioBaja = new String[] {""} ;
         P000D2_n195TTBUS_UsuarioBaja = new bool[] {false} ;
         P000D2_A196TTBUS_MaquinaBaja = new String[] {""} ;
         P000D2_n196TTBUS_MaquinaBaja = new bool[] {false} ;
         P000D2_A23TTBUS_Estado = new short[1] ;
         A195TTBUS_UsuarioBaja = "" ;
         A196TTBUS_MaquinaBaja = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus000_b_1__default(),
            new Object[][] {
                new Object[] {
               P000D2_A11TTBUS_Id, P000D2_A195TTBUS_UsuarioBaja, P000D2_n195TTBUS_UsuarioBaja, P000D2_A196TTBUS_MaquinaBaja, P000D2_n196TTBUS_MaquinaBaja, P000D2_A23TTBUS_Estado
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A23TTBUS_Estado ;
      private int AV9TTBUS_Id ;
      private int A11TTBUS_Id ;
      private String AV8USUARIO ;
      private String scmdbuf ;
      private String A195TTBUS_UsuarioBaja ;
      private String A196TTBUS_MaquinaBaja ;
      private bool n195TTBUS_UsuarioBaja ;
      private bool n196TTBUS_MaquinaBaja ;
      private IGxDataStore dsDefault ;
      private int aP0_TTBUS_Id ;
      private String aP1_USUARIO ;
      private IDataStoreProvider pr_default ;
      private int[] P000D2_A11TTBUS_Id ;
      private String[] P000D2_A195TTBUS_UsuarioBaja ;
      private bool[] P000D2_n195TTBUS_UsuarioBaja ;
      private String[] P000D2_A196TTBUS_MaquinaBaja ;
      private bool[] P000D2_n196TTBUS_MaquinaBaja ;
      private short[] P000D2_A23TTBUS_Estado ;
   }

   public class ptbus000_b_1__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000D2 ;
          prmP000D2 = new Object[] {
          new Object[] {"@AV9TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP000D3 ;
          prmP000D3 = new Object[] {
          new Object[] {"@TTBUS_UsuarioBaja",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS_MaquinaBaja",SqlDbType.Char,20,0} ,
          new Object[] {"@TTBUS_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000D2", "SELECT [TTBUS_Id], [TTBUS_UsuarioBaja], [TTBUS_MaquinaBaja], [TTBUS_Estado] FROM [TTBUS000] WITH (UPDLOCK) WHERE [TTBUS_Id] = @AV9TTBUS_Id ORDER BY [TTBUS_Id] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000D2,1,0,true,true )
             ,new CursorDef("P000D3", "UPDATE [TTBUS000] SET [TTBUS_UsuarioBaja]=@TTBUS_UsuarioBaja, [TTBUS_MaquinaBaja]=@TTBUS_MaquinaBaja, [TTBUS_Estado]=@TTBUS_Estado  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000D3)
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 20) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                stmt.SetParameter(3, (short)parms[4]);
                stmt.SetParameter(4, (int)parms[5]);
                break;
       }
    }

 }

}
