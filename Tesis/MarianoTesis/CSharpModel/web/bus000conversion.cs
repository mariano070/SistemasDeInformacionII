/*
               File: BUS000Conversion
        Description: Conversion for table BUS000
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/27/2014 14:59:34.61
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
   public class bus000conversion : GXProcedure
   {
      public bus000conversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public bus000conversion( IGxContext context )
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
         bus000conversion objbus000conversion;
         objbus000conversion = new bus000conversion();
         objbus000conversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objbus000conversion.executePrivateCatch ));
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
         /* Using cursor BUS000CONV2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A103BUS_IDT = BUS000CONV2_A103BUS_IDT[0] ;
            A346BUS_AEH = BUS000CONV2_A346BUS_AEH[0] ;
            A345BUS_AAH = BUS000CONV2_A345BUS_AAH[0] ;
            A344BUS_VOH = BUS000CONV2_A344BUS_VOH[0] ;
            A343BUS_VHF = BUS000CONV2_A343BUS_VHF[0] ;
            A342BUS_VAH = BUS000CONV2_A342BUS_VAH[0] ;
            A339BUS_AEA = BUS000CONV2_A339BUS_AEA[0] ;
            A338BUS_AAA = BUS000CONV2_A338BUS_AAA[0] ;
            A337BUS_VOA = BUS000CONV2_A337BUS_VOA[0] ;
            A341BUS_VOC = BUS000CONV2_A341BUS_VOC[0] ;
            A336BUS_COE = BUS000CONV2_A336BUS_COE[0] ;
            A335BUS_VUT = BUS000CONV2_A335BUS_VUT[0] ;
            A340BUS_FPR = BUS000CONV2_A340BUS_FPR[0] ;
            A334BUS_MBA = BUS000CONV2_A334BUS_MBA[0] ;
            A174BUS_FBA = BUS000CONV2_A174BUS_FBA[0] ;
            A59BUS_TID = BUS000CONV2_A59BUS_TID[0] ;
            A56BUS_TIP = BUS000CONV2_A56BUS_TIP[0] ;
            A176BUS_SED = BUS000CONV2_A176BUS_SED[0] ;
            A172BUS_SEC = BUS000CONV2_A172BUS_SEC[0] ;
            A175BUS_ARD = BUS000CONV2_A175BUS_ARD[0] ;
            A171BUS_ARE = BUS000CONV2_A171BUS_ARE[0] ;
            A333BUS_NCO = BUS000CONV2_A333BUS_NCO[0] ;
            A350BUS_CBD = BUS000CONV2_A350BUS_CBD[0] ;
            A331BUS_COM = BUS000CONV2_A331BUS_COM[0] ;
            A330BUS_VAO = BUS000CONV2_A330BUS_VAO[0] ;
            A329BUS_VUA = BUS000CONV2_A329BUS_VUA[0] ;
            A55BUS_FAD = BUS000CONV2_A55BUS_FAD[0] ;
            A170BUS_FAL = BUS000CONV2_A170BUS_FAL[0] ;
            A54BUS_DES = BUS000CONV2_A54BUS_DES[0] ;
            A4BUS_PAR = BUS000CONV2_A4BUS_PAR[0] ;
            A3BUS_COD = BUS000CONV2_A3BUS_COD[0] ;
            A1BUS_RUB = BUS000CONV2_A1BUS_RUB[0] ;
            A8BUS_EMP = BUS000CONV2_A8BUS_EMP[0] ;
            /*
               INSERT RECORD ON TABLE GXA0024

            */
            AV2BUS_EMP = A8BUS_EMP ;
            AV3BUS_RUB = A1BUS_RUB ;
            AV4BUS_COD = A3BUS_COD ;
            AV5BUS_PAR = A4BUS_PAR ;
            AV6BUS_AMO = A178BUS_AMO ;
            AV7BUS_DES = A54BUS_DES ;
            AV8BUS_FAL = A170BUS_FAL ;
            AV9BUS_FAD = A55BUS_FAD ;
            AV10BUS_VUA = A329BUS_VUA ;
            AV11BUS_VAO = A330BUS_VAO ;
            AV12BUS_COM = A331BUS_COM ;
            AV13BUS_CBD = A350BUS_CBD ;
            AV14BUS_NCO = A333BUS_NCO ;
            AV15BUS_ARE = A171BUS_ARE ;
            AV16BUS_ARD = A175BUS_ARD ;
            AV17BUS_SEC = A172BUS_SEC ;
            AV18BUS_SED = A176BUS_SED ;
            AV19BUS_TIP = A56BUS_TIP ;
            AV20BUS_TID = A59BUS_TID ;
            AV21BUS_FBA = A174BUS_FBA ;
            AV22BUS_MBA = A334BUS_MBA ;
            AV23BUS_FPR = A340BUS_FPR ;
            AV24BUS_VUT = A335BUS_VUT ;
            AV25BUS_COE = A336BUS_COE ;
            AV26BUS_VOC = A341BUS_VOC ;
            AV27BUS_VOA = A337BUS_VOA ;
            AV28BUS_AAA = A338BUS_AAA ;
            AV29BUS_AEA = A339BUS_AEA ;
            AV30BUS_VAH = A342BUS_VAH ;
            AV31BUS_VHF = A343BUS_VHF ;
            AV32BUS_VOH = A344BUS_VOH ;
            AV33BUS_AAH = A345BUS_AAH ;
            AV34BUS_AEH = A346BUS_AEH ;
            AV35BUS_IDT = A103BUS_IDT ;
            /* Using cursor BUS000CONV3 */
            pr_default.execute(1, new Object[] {AV2BUS_EMP, AV3BUS_RUB, AV4BUS_COD, AV5BUS_PAR, AV6BUS_AMO, AV7BUS_DES, AV8BUS_FAL, AV9BUS_FAD, AV10BUS_VUA, AV11BUS_VAO, AV12BUS_COM, AV13BUS_CBD, AV14BUS_NCO, AV15BUS_ARE, AV16BUS_ARD, AV17BUS_SEC, AV18BUS_SED, AV19BUS_TIP, AV20BUS_TID, AV21BUS_FBA, AV22BUS_MBA, AV23BUS_FPR, AV24BUS_VUT, AV25BUS_COE, AV26BUS_VOC, AV27BUS_VOA, AV28BUS_AAA, AV29BUS_AEA, AV30BUS_VAH, AV31BUS_VHF, AV32BUS_VOH, AV33BUS_AAH, AV34BUS_AEH, AV35BUS_IDT});
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
         BUS000CONV2_A103BUS_IDT = new int[1] ;
         BUS000CONV2_A346BUS_AEH = new decimal[1] ;
         BUS000CONV2_A345BUS_AAH = new decimal[1] ;
         BUS000CONV2_A344BUS_VOH = new decimal[1] ;
         BUS000CONV2_A343BUS_VHF = new DateTime[] {DateTime.MinValue} ;
         BUS000CONV2_A342BUS_VAH = new decimal[1] ;
         BUS000CONV2_A339BUS_AEA = new decimal[1] ;
         BUS000CONV2_A338BUS_AAA = new decimal[1] ;
         BUS000CONV2_A337BUS_VOA = new decimal[1] ;
         BUS000CONV2_A341BUS_VOC = new decimal[1] ;
         BUS000CONV2_A336BUS_COE = new decimal[1] ;
         BUS000CONV2_A335BUS_VUT = new short[1] ;
         BUS000CONV2_A340BUS_FPR = new DateTime[] {DateTime.MinValue} ;
         BUS000CONV2_A334BUS_MBA = new String[] {""} ;
         BUS000CONV2_A174BUS_FBA = new DateTime[] {DateTime.MinValue} ;
         BUS000CONV2_A59BUS_TID = new String[] {""} ;
         BUS000CONV2_A56BUS_TIP = new short[1] ;
         BUS000CONV2_A176BUS_SED = new String[] {""} ;
         BUS000CONV2_A172BUS_SEC = new short[1] ;
         BUS000CONV2_A175BUS_ARD = new String[] {""} ;
         BUS000CONV2_A171BUS_ARE = new short[1] ;
         BUS000CONV2_A333BUS_NCO = new String[] {""} ;
         BUS000CONV2_A350BUS_CBD = new String[] {""} ;
         BUS000CONV2_A331BUS_COM = new String[] {""} ;
         BUS000CONV2_A330BUS_VAO = new decimal[1] ;
         BUS000CONV2_A329BUS_VUA = new short[1] ;
         BUS000CONV2_A55BUS_FAD = new DateTime[] {DateTime.MinValue} ;
         BUS000CONV2_A170BUS_FAL = new DateTime[] {DateTime.MinValue} ;
         BUS000CONV2_A54BUS_DES = new String[] {""} ;
         BUS000CONV2_A4BUS_PAR = new short[1] ;
         BUS000CONV2_A3BUS_COD = new short[1] ;
         BUS000CONV2_A1BUS_RUB = new short[1] ;
         BUS000CONV2_A8BUS_EMP = new String[] {""} ;
         A343BUS_VHF = DateTime.MinValue ;
         A340BUS_FPR = DateTime.MinValue ;
         A334BUS_MBA = "" ;
         A174BUS_FBA = DateTime.MinValue ;
         A59BUS_TID = "" ;
         A176BUS_SED = "" ;
         A175BUS_ARD = "" ;
         A333BUS_NCO = "" ;
         A350BUS_CBD = "" ;
         A331BUS_COM = "" ;
         A55BUS_FAD = DateTime.MinValue ;
         A170BUS_FAL = DateTime.MinValue ;
         A54BUS_DES = "" ;
         A8BUS_EMP = "" ;
         AV2BUS_EMP = "" ;
         AV6BUS_AMO = "" ;
         A178BUS_AMO = "" ;
         AV7BUS_DES = "" ;
         AV8BUS_FAL = DateTime.MinValue ;
         AV9BUS_FAD = DateTime.MinValue ;
         AV12BUS_COM = "" ;
         AV13BUS_CBD = "" ;
         AV14BUS_NCO = "" ;
         AV16BUS_ARD = "" ;
         AV18BUS_SED = "" ;
         AV20BUS_TID = "" ;
         AV21BUS_FBA = DateTime.MinValue ;
         AV22BUS_MBA = "" ;
         AV23BUS_FPR = DateTime.MinValue ;
         AV31BUS_VHF = DateTime.MinValue ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.bus000conversion__default(),
            new Object[][] {
                new Object[] {
               BUS000CONV2_A103BUS_IDT, BUS000CONV2_A346BUS_AEH, BUS000CONV2_A345BUS_AAH, BUS000CONV2_A344BUS_VOH, BUS000CONV2_A343BUS_VHF, BUS000CONV2_A342BUS_VAH, BUS000CONV2_A339BUS_AEA, BUS000CONV2_A338BUS_AAA, BUS000CONV2_A337BUS_VOA, BUS000CONV2_A341BUS_VOC,
               BUS000CONV2_A336BUS_COE, BUS000CONV2_A335BUS_VUT, BUS000CONV2_A340BUS_FPR, BUS000CONV2_A334BUS_MBA, BUS000CONV2_A174BUS_FBA, BUS000CONV2_A59BUS_TID, BUS000CONV2_A56BUS_TIP, BUS000CONV2_A176BUS_SED, BUS000CONV2_A172BUS_SEC, BUS000CONV2_A175BUS_ARD,
               BUS000CONV2_A171BUS_ARE, BUS000CONV2_A333BUS_NCO, BUS000CONV2_A350BUS_CBD, BUS000CONV2_A331BUS_COM, BUS000CONV2_A330BUS_VAO, BUS000CONV2_A329BUS_VUA, BUS000CONV2_A55BUS_FAD, BUS000CONV2_A170BUS_FAL, BUS000CONV2_A54BUS_DES, BUS000CONV2_A4BUS_PAR,
               BUS000CONV2_A3BUS_COD, BUS000CONV2_A1BUS_RUB, BUS000CONV2_A8BUS_EMP
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A335BUS_VUT ;
      private short A56BUS_TIP ;
      private short A172BUS_SEC ;
      private short A171BUS_ARE ;
      private short A329BUS_VUA ;
      private short A4BUS_PAR ;
      private short A3BUS_COD ;
      private short A1BUS_RUB ;
      private short AV3BUS_RUB ;
      private short AV4BUS_COD ;
      private short AV5BUS_PAR ;
      private short AV10BUS_VUA ;
      private short AV15BUS_ARE ;
      private short AV17BUS_SEC ;
      private short AV19BUS_TIP ;
      private short AV24BUS_VUT ;
      private int A103BUS_IDT ;
      private int GIGXA0024 ;
      private int AV35BUS_IDT ;
      private decimal A346BUS_AEH ;
      private decimal A345BUS_AAH ;
      private decimal A344BUS_VOH ;
      private decimal A342BUS_VAH ;
      private decimal A339BUS_AEA ;
      private decimal A338BUS_AAA ;
      private decimal A337BUS_VOA ;
      private decimal A341BUS_VOC ;
      private decimal A336BUS_COE ;
      private decimal A330BUS_VAO ;
      private decimal AV11BUS_VAO ;
      private decimal AV25BUS_COE ;
      private decimal AV26BUS_VOC ;
      private decimal AV27BUS_VOA ;
      private decimal AV28BUS_AAA ;
      private decimal AV29BUS_AEA ;
      private decimal AV30BUS_VAH ;
      private decimal AV32BUS_VOH ;
      private decimal AV33BUS_AAH ;
      private decimal AV34BUS_AEH ;
      private String scmdbuf ;
      private String A334BUS_MBA ;
      private String A59BUS_TID ;
      private String A176BUS_SED ;
      private String A175BUS_ARD ;
      private String A333BUS_NCO ;
      private String A350BUS_CBD ;
      private String A331BUS_COM ;
      private String A54BUS_DES ;
      private String A8BUS_EMP ;
      private String AV2BUS_EMP ;
      private String AV6BUS_AMO ;
      private String A178BUS_AMO ;
      private String AV7BUS_DES ;
      private String AV12BUS_COM ;
      private String AV13BUS_CBD ;
      private String AV14BUS_NCO ;
      private String AV16BUS_ARD ;
      private String AV18BUS_SED ;
      private String AV20BUS_TID ;
      private String AV22BUS_MBA ;
      private String Gx_emsg ;
      private DateTime A343BUS_VHF ;
      private DateTime A340BUS_FPR ;
      private DateTime A174BUS_FBA ;
      private DateTime A55BUS_FAD ;
      private DateTime A170BUS_FAL ;
      private DateTime AV8BUS_FAL ;
      private DateTime AV9BUS_FAD ;
      private DateTime AV21BUS_FBA ;
      private DateTime AV23BUS_FPR ;
      private DateTime AV31BUS_VHF ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BUS000CONV2_A103BUS_IDT ;
      private decimal[] BUS000CONV2_A346BUS_AEH ;
      private decimal[] BUS000CONV2_A345BUS_AAH ;
      private decimal[] BUS000CONV2_A344BUS_VOH ;
      private DateTime[] BUS000CONV2_A343BUS_VHF ;
      private decimal[] BUS000CONV2_A342BUS_VAH ;
      private decimal[] BUS000CONV2_A339BUS_AEA ;
      private decimal[] BUS000CONV2_A338BUS_AAA ;
      private decimal[] BUS000CONV2_A337BUS_VOA ;
      private decimal[] BUS000CONV2_A341BUS_VOC ;
      private decimal[] BUS000CONV2_A336BUS_COE ;
      private short[] BUS000CONV2_A335BUS_VUT ;
      private DateTime[] BUS000CONV2_A340BUS_FPR ;
      private String[] BUS000CONV2_A334BUS_MBA ;
      private DateTime[] BUS000CONV2_A174BUS_FBA ;
      private String[] BUS000CONV2_A59BUS_TID ;
      private short[] BUS000CONV2_A56BUS_TIP ;
      private String[] BUS000CONV2_A176BUS_SED ;
      private short[] BUS000CONV2_A172BUS_SEC ;
      private String[] BUS000CONV2_A175BUS_ARD ;
      private short[] BUS000CONV2_A171BUS_ARE ;
      private String[] BUS000CONV2_A333BUS_NCO ;
      private String[] BUS000CONV2_A350BUS_CBD ;
      private String[] BUS000CONV2_A331BUS_COM ;
      private decimal[] BUS000CONV2_A330BUS_VAO ;
      private short[] BUS000CONV2_A329BUS_VUA ;
      private DateTime[] BUS000CONV2_A55BUS_FAD ;
      private DateTime[] BUS000CONV2_A170BUS_FAL ;
      private String[] BUS000CONV2_A54BUS_DES ;
      private short[] BUS000CONV2_A4BUS_PAR ;
      private short[] BUS000CONV2_A3BUS_COD ;
      private short[] BUS000CONV2_A1BUS_RUB ;
      private String[] BUS000CONV2_A8BUS_EMP ;
   }

   public class bus000conversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBUS000CONV2 ;
          prmBUS000CONV2 = new Object[] {
          } ;
          Object[] prmBUS000CONV3 ;
          prmBUS000CONV3 = new Object[] {
          new Object[] {"@AV2BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@AV3BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV4BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5BUS_PAR",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV6BUS_AMO",SqlDbType.Char,1,0} ,
          new Object[] {"@AV7BUS_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@AV8BUS_FAL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV9BUS_FAD",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV10BUS_VUA",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11BUS_VAO",SqlDbType.Decimal,18,7} ,
          new Object[] {"@AV12BUS_COM",SqlDbType.Char,2,0} ,
          new Object[] {"@AV13BUS_CBD",SqlDbType.Char,20,0} ,
          new Object[] {"@AV14BUS_NCO",SqlDbType.Char,12,0} ,
          new Object[] {"@AV15BUS_ARE",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV16BUS_ARD",SqlDbType.Char,30,0} ,
          new Object[] {"@AV17BUS_SEC",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV18BUS_SED",SqlDbType.Char,30,0} ,
          new Object[] {"@AV19BUS_TIP",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV20BUS_TID",SqlDbType.Char,20,0} ,
          new Object[] {"@AV21BUS_FBA",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV22BUS_MBA",SqlDbType.Char,30,0} ,
          new Object[] {"@AV23BUS_FPR",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV24BUS_VUT",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV25BUS_COE",SqlDbType.Decimal,18,7} ,
          new Object[] {"@AV26BUS_VOC",SqlDbType.Decimal,18,7} ,
          new Object[] {"@AV27BUS_VOA",SqlDbType.Decimal,18,7} ,
          new Object[] {"@AV28BUS_AAA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV29BUS_AEA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV30BUS_VAH",SqlDbType.Decimal,18,7} ,
          new Object[] {"@AV31BUS_VHF",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV32BUS_VOH",SqlDbType.Decimal,18,7} ,
          new Object[] {"@AV33BUS_AAH",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV34BUS_AEH",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV35BUS_IDT",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BUS000CONV2", "SELECT [BUS_IDT], [BUS_AEH], [BUS_AAH], [BUS_VOH], [BUS_VHF], [BUS_VAH], [BUS_AEA], [BUS_AAA], [BUS_VOA], [BUS_VOC], [BUS_COE], [BUS_VUT], [BUS_FPR], [BUS_MBA], [BUS_FBA], [BUS_TID], [BUS_TIP], [BUS_SED], [BUS_SEC], [BUS_ARD], [BUS_ARE], [BUS_NCO], [BUS_CBD], [BUS_COM], [BUS_VAO], [BUS_VUA], [BUS_FAD], [BUS_FAL], [BUS_DES], [BUS_PAR], [BUS_COD], [BUS_RUB], [BUS_EMP] FROM [BUS000] ORDER BY [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmBUS000CONV2,100,0,true,false )
             ,new CursorDef("BUS000CONV3", "INSERT INTO [GXA0024] ([BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR], [BUS_AMO], [BUS_DES], [BUS_FAL], [BUS_FAD], [BUS_VUA], [BUS_VAO], [BUS_COM], [BUS_CBD], [BUS_NCO], [BUS_ARE], [BUS_ARD], [BUS_SEC], [BUS_SED], [BUS_TIP], [BUS_TID], [BUS_FBA], [BUS_MBA], [BUS_FPR], [BUS_VUT], [BUS_COE], [BUS_VOC], [BUS_VOA], [BUS_AAA], [BUS_AEA], [BUS_VAH], [BUS_VHF], [BUS_VOH], [BUS_AAH], [BUS_AEH], [BUS_IDT]) VALUES (@AV2BUS_EMP, @AV3BUS_RUB, @AV4BUS_COD, @AV5BUS_PAR, @AV6BUS_AMO, @AV7BUS_DES, @AV8BUS_FAL, @AV9BUS_FAD, @AV10BUS_VUA, @AV11BUS_VAO, @AV12BUS_COM, @AV13BUS_CBD, @AV14BUS_NCO, @AV15BUS_ARE, @AV16BUS_ARD, @AV17BUS_SEC, @AV18BUS_SED, @AV19BUS_TIP, @AV20BUS_TID, @AV21BUS_FBA, @AV22BUS_MBA, @AV23BUS_FPR, @AV24BUS_VUT, @AV25BUS_COE, @AV26BUS_VOC, @AV27BUS_VOA, @AV28BUS_AAA, @AV29BUS_AEA, @AV30BUS_VAH, @AV31BUS_VHF, @AV32BUS_VOH, @AV33BUS_AAH, @AV34BUS_AEH, @AV35BUS_IDT)", GxErrorMask.GX_NOMASK,prmBUS000CONV3)
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((DateTime[]) buf[12])[0] = rslt.getGXDate(13) ;
                ((String[]) buf[13])[0] = rslt.getString(14, 30) ;
                ((DateTime[]) buf[14])[0] = rslt.getGXDate(15) ;
                ((String[]) buf[15])[0] = rslt.getString(16, 20) ;
                ((short[]) buf[16])[0] = rslt.getShort(17) ;
                ((String[]) buf[17])[0] = rslt.getString(18, 30) ;
                ((short[]) buf[18])[0] = rslt.getShort(19) ;
                ((String[]) buf[19])[0] = rslt.getString(20, 30) ;
                ((short[]) buf[20])[0] = rslt.getShort(21) ;
                ((String[]) buf[21])[0] = rslt.getString(22, 12) ;
                ((String[]) buf[22])[0] = rslt.getString(23, 20) ;
                ((String[]) buf[23])[0] = rslt.getString(24, 2) ;
                ((decimal[]) buf[24])[0] = rslt.getDecimal(25) ;
                ((short[]) buf[25])[0] = rslt.getShort(26) ;
                ((DateTime[]) buf[26])[0] = rslt.getGXDate(27) ;
                ((DateTime[]) buf[27])[0] = rslt.getGXDate(28) ;
                ((String[]) buf[28])[0] = rslt.getString(29, 50) ;
                ((short[]) buf[29])[0] = rslt.getShort(30) ;
                ((short[]) buf[30])[0] = rslt.getShort(31) ;
                ((short[]) buf[31])[0] = rslt.getShort(32) ;
                ((String[]) buf[32])[0] = rslt.getString(33, 1) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                stmt.SetParameter(10, (decimal)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (short)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                stmt.SetParameter(16, (short)parms[15]);
                stmt.SetParameter(17, (String)parms[16]);
                stmt.SetParameter(18, (short)parms[17]);
                stmt.SetParameter(19, (String)parms[18]);
                stmt.SetParameter(20, (DateTime)parms[19]);
                stmt.SetParameter(21, (String)parms[20]);
                stmt.SetParameter(22, (DateTime)parms[21]);
                stmt.SetParameter(23, (short)parms[22]);
                stmt.SetParameter(24, (decimal)parms[23]);
                stmt.SetParameter(25, (decimal)parms[24]);
                stmt.SetParameter(26, (decimal)parms[25]);
                stmt.SetParameter(27, (decimal)parms[26]);
                stmt.SetParameter(28, (decimal)parms[27]);
                stmt.SetParameter(29, (decimal)parms[28]);
                stmt.SetParameter(30, (DateTime)parms[29]);
                stmt.SetParameter(31, (decimal)parms[30]);
                stmt.SetParameter(32, (decimal)parms[31]);
                stmt.SetParameter(33, (decimal)parms[32]);
                stmt.SetParameter(34, (int)parms[33]);
                break;
       }
    }

 }

}
