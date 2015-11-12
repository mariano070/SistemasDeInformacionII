/*
               File: GESTORESConversion
        Description: Conversion for table GESTORES
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:5:33.1
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class gestoresconversion : GXProcedure
   {
      public gestoresconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public gestoresconversion( IGxContext context )
      {
         this.DisconnectAtCleanup = true;
         context = context.UtlClone();
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         gestoresconversion objgestoresconversion;
         objgestoresconversion = new gestoresconversion();
         objgestoresconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objgestoresconversion.executePrivateCatch ));
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
         /* Using cursor GESTORESCO2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A267GestorRamoDes = GESTORESCO2_A267GestorRamoDes[0] ;
            A265GestorRamoCod = GESTORESCO2_A265GestorRamoCod[0] ;
            n265GestorRamoCod = GESTORESCO2_n265GestorRamoCod[0] ;
            A261GestorRolDes = GESTORESCO2_A261GestorRolDes[0] ;
            A263GestorRolCod = GESTORESCO2_A263GestorRolCod[0] ;
            n263GestorRolCod = GESTORESCO2_n263GestorRolCod[0] ;
            A260GestorCod = GESTORESCO2_A260GestorCod[0] ;
            /*
               INSERT RECORD ON TABLE GXA0017

            */
            AV2GestorCod = A260GestorCod ;
            if ( GESTORESCO2_n263GestorRolCod[0] )
            {
               AV3GestorRolCod = 0 ;
               nV3GestorRolCod = false ;
               nV3GestorRolCod = true ;
            }
            else
            {
               AV3GestorRolCod = A263GestorRolCod ;
               nV3GestorRolCod = false ;
            }
            AV4GestorRolDes = A261GestorRolDes ;
            if ( GESTORESCO2_n265GestorRamoCod[0] )
            {
               AV5GestorRamoCod = 0 ;
               nV5GestorRamoCod = false ;
               nV5GestorRamoCod = true ;
            }
            else
            {
               AV5GestorRamoCod = A265GestorRamoCod ;
               nV5GestorRamoCod = false ;
            }
            AV6GestorRamoDes = A267GestorRamoDes ;
            /* Using cursor GESTORESCO3 */
            pr_default.execute(1, new Object[] {AV2GestorCod, nV3GestorRolCod, AV3GestorRolCod, AV4GestorRolDes, nV5GestorRamoCod, AV5GestorRamoCod, AV6GestorRamoDes});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         GESTORESCO2_A267GestorRamoDes = new String[] {""} ;
         GESTORESCO2_A265GestorRamoCod = new short[1] ;
         GESTORESCO2_n265GestorRamoCod = new bool[] {false} ;
         GESTORESCO2_A261GestorRolDes = new String[] {""} ;
         GESTORESCO2_A263GestorRolCod = new short[1] ;
         GESTORESCO2_n263GestorRolCod = new bool[] {false} ;
         GESTORESCO2_A260GestorCod = new String[] {""} ;
         A267GestorRamoDes = "" ;
         A261GestorRolDes = "" ;
         A260GestorCod = "" ;
         AV2GestorCod = "" ;
         AV4GestorRolDes = "" ;
         AV6GestorRamoDes = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gestoresconversion__default(),
            new Object[][] {
                new Object[] {
               GESTORESCO2_A267GestorRamoDes, GESTORESCO2_A265GestorRamoCod, GESTORESCO2_n265GestorRamoCod, GESTORESCO2_A261GestorRolDes, GESTORESCO2_A263GestorRolCod, GESTORESCO2_n263GestorRolCod, GESTORESCO2_A260GestorCod
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A265GestorRamoCod ;
      private short A263GestorRolCod ;
      private short AV3GestorRolCod ;
      private short AV5GestorRamoCod ;
      private int GIGXA0017 ;
      private String scmdbuf ;
      private String A267GestorRamoDes ;
      private String A261GestorRolDes ;
      private String A260GestorCod ;
      private String AV2GestorCod ;
      private String AV4GestorRolDes ;
      private String AV6GestorRamoDes ;
      private String Gx_emsg ;
      private bool n265GestorRamoCod ;
      private bool n263GestorRolCod ;
      private bool nV3GestorRolCod ;
      private bool nV5GestorRamoCod ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] GESTORESCO2_A267GestorRamoDes ;
      private short[] GESTORESCO2_A265GestorRamoCod ;
      private bool[] GESTORESCO2_n265GestorRamoCod ;
      private String[] GESTORESCO2_A261GestorRolDes ;
      private short[] GESTORESCO2_A263GestorRolCod ;
      private bool[] GESTORESCO2_n263GestorRolCod ;
      private String[] GESTORESCO2_A260GestorCod ;
   }

   public class gestoresconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmGESTORESCO2 ;
          prmGESTORESCO2 = new Object[] {
          } ;
          Object[] prmGESTORESCO3 ;
          prmGESTORESCO3 = new Object[] {
          new Object[] {"@AV2GestorCod",SqlDbType.Char,16,0} ,
          new Object[] {"@AV3GestorRolCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV4GestorRolDes",SqlDbType.Char,20,0} ,
          new Object[] {"@AV5GestorRamoCod",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV6GestorRamoDes",SqlDbType.Char,30,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("GESTORESCO2", "SELECT [GestorRamoDes], [GestorRamoCod], [GestorRolDes], [GestorRolCod], [GestorCod] FROM [GESTORES] ORDER BY [GestorCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmGESTORESCO2,100,0,true,false )
             ,new CursorDef("GESTORESCO3", "INSERT INTO [GXA0017] ([GestorCod], [GestorRolCod], [GestorRolDes], [GestorRamoCod], [GestorRamoDes]) VALUES (@AV2GestorCod, @AV3GestorRolCod, @AV4GestorRolDes, @AV5GestorRamoCod, @AV6GestorRamoDes)", GxErrorMask.GX_NOMASK,prmGESTORESCO3)
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
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 15) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[2]);
                }
                stmt.SetParameter(3, (String)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[5]);
                }
                stmt.SetParameter(5, (String)parms[6]);
                break;
       }
    }

 }

}
