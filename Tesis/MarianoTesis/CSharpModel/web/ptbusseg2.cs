/*
               File: PTBUSSEG2
        Description: Alta en TTBUS008
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:57.57
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
   public class ptbusseg2 : GXProcedure
   {
      public ptbusseg2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbusseg2( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USU_COD ,
                           ref short aP1_Administrador ,
                           ref String aP2_Modo )
      {
         this.AV8USU_COD = aP0_USU_COD;
         this.AV10Administrador = aP1_Administrador;
         this.AV9Modo = aP2_Modo;
         initialize();
         executePrivate();
         aP0_USU_COD=this.AV8USU_COD;
         aP1_Administrador=this.AV10Administrador;
         aP2_Modo=this.AV9Modo;
      }

      public String executeUdp( ref String aP0_USU_COD ,
                                ref short aP1_Administrador )
      {
         this.AV8USU_COD = aP0_USU_COD;
         this.AV10Administrador = aP1_Administrador;
         this.AV9Modo = aP2_Modo;
         initialize();
         executePrivate();
         aP0_USU_COD=this.AV8USU_COD;
         aP1_Administrador=this.AV10Administrador;
         aP2_Modo=this.AV9Modo;
         return AV9Modo ;
      }

      public void executeSubmit( ref String aP0_USU_COD ,
                                 ref short aP1_Administrador ,
                                 ref String aP2_Modo )
      {
         ptbusseg2 objptbusseg2;
         objptbusseg2 = new ptbusseg2();
         objptbusseg2.AV8USU_COD = aP0_USU_COD;
         objptbusseg2.AV10Administrador = aP1_Administrador;
         objptbusseg2.AV9Modo = aP2_Modo;
         objptbusseg2.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbusseg2.executePrivateCatch ));
         aP0_USU_COD=this.AV8USU_COD;
         aP1_Administrador=this.AV10Administrador;
         aP2_Modo=this.AV9Modo;
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
         if ( StringUtil.StrCmp(AV9Modo, "INS") == 0 )
         {
            if ( AV10Administrador == 1 )
            {
               /*
                  INSERT RECORD ON TABLE TTBUS008

               */
               A40TTBUS8_CodUsuario = AV8USU_COD ;
               /* Using cursor P002N2 */
               pr_default.execute(0, new Object[] {A40TTBUS8_CodUsuario});
               pr_default.close(0);
               if ( (pr_default.getStatus(0) == 1) )
               {
                  context.Gx_err = 1 ;
                  Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
               }
               else
               {
                  context.Gx_err = 0 ;
                  Gx_emsg = "" ;
               }
               /* End Insert */
            }
         }
         else if ( StringUtil.StrCmp(AV9Modo, "UPD") == 0 )
         {
            AV13GXLvl11 = 0 ;
            /* Using cursor P002N3 */
            pr_default.execute(1, new Object[] {AV8USU_COD});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A40TTBUS8_CodUsuario = P002N3_A40TTBUS8_CodUsuario[0] ;
               AV13GXLvl11 = 1 ;
               if ( AV10Administrador == 0 )
               {
                  /* Using cursor P002N4 */
                  pr_default.execute(2, new Object[] {A40TTBUS8_CodUsuario});
                  pr_default.close(2);
               }
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            if ( AV13GXLvl11 == 0 )
            {
               if ( AV10Administrador == 1 )
               {
                  /*
                     INSERT RECORD ON TABLE TTBUS008

                  */
                  A40TTBUS8_CodUsuario = AV8USU_COD ;
                  /* Using cursor P002N5 */
                  pr_default.execute(3, new Object[] {A40TTBUS8_CodUsuario});
                  pr_default.close(3);
                  if ( (pr_default.getStatus(3) == 1) )
                  {
                     context.Gx_err = 1 ;
                     Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
                  }
                  else
                  {
                     context.Gx_err = 0 ;
                     Gx_emsg = "" ;
                  }
                  /* End Insert */
               }
            }
         }
         else if ( StringUtil.StrCmp(AV9Modo, "DLT") == 0 )
         {
            /* Optimized DELETE. */
            /* Using cursor P002N6 */
            pr_default.execute(4, new Object[] {AV8USU_COD});
            pr_default.close(4);
            /* End optimized DELETE. */
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUSSEG2");
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
         A40TTBUS8_CodUsuario = "" ;
         Gx_emsg = "" ;
         scmdbuf = "" ;
         P002N3_A40TTBUS8_CodUsuario = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbusseg2__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               P002N3_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV10Administrador ;
      private short AV13GXLvl11 ;
      private int GX_INS9 ;
      private String AV8USU_COD ;
      private String AV9Modo ;
      private String A40TTBUS8_CodUsuario ;
      private String Gx_emsg ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private String aP0_USU_COD ;
      private short aP1_Administrador ;
      private String aP2_Modo ;
      private IDataStoreProvider pr_default ;
      private String[] P002N3_A40TTBUS8_CodUsuario ;
   }

   public class ptbusseg2__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
         ,new UpdateCursor(def[3])
         ,new UpdateCursor(def[4])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002N2 ;
          prmP002N2 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002N3 ;
          prmP002N3 = new Object[] {
          new Object[] {"@AV8USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002N4 ;
          prmP002N4 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002N5 ;
          prmP002N5 = new Object[] {
          new Object[] {"@TTBUS8_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002N6 ;
          prmP002N6 = new Object[] {
          new Object[] {"@AV8USU_COD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002N2", "INSERT INTO [TTBUS008] ([TTBUS8_CodUsuario]) VALUES (@TTBUS8_CodUsuario)", GxErrorMask.GX_NOMASK,prmP002N2)
             ,new CursorDef("P002N3", "SELECT [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (UPDLOCK) WHERE [TTBUS8_CodUsuario] = @AV8USU_COD ORDER BY [TTBUS8_CodUsuario] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002N3,1,0,true,true )
             ,new CursorDef("P002N4", "DELETE FROM [TTBUS008]  WHERE [TTBUS8_CodUsuario] = @TTBUS8_CodUsuario", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002N4)
             ,new CursorDef("P002N5", "INSERT INTO [TTBUS008] ([TTBUS8_CodUsuario]) VALUES (@TTBUS8_CodUsuario)", GxErrorMask.GX_NOMASK,prmP002N5)
             ,new CursorDef("P002N6", "DELETE FROM [TTBUS008]  WHERE [TTBUS8_CodUsuario] = @AV8USU_COD", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002N6)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 1 :
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
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
