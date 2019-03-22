
'------------------------------------------------------------------------------
' <copyright file="Inventory.sdo.vb" company="Microsoft">
'     Copyright (c) Microsoft Corporation.  All rights reserved.
' </copyright>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoInventory

    Public Class Inventory
        Inherits SolomonDataObject

        <
        DataBinding(PropertyIndex:=0, StringSize:=2)
        >
        Public Property ABCCode() As String

            Get
                Return Me.GetPropertyValue("ABCCode")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("ABCCode", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=1)
        >
        Public Property ApprovedVendor() As Short

            Get
                Return Me.GetPropertyValue("ApprovedVendor")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("ApprovedVendor", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=2)
        >
        Public Property AutoPODropShip() As Short

            Get
                Return Me.GetPropertyValue("AutoPODropShip")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("AutoPODropShip", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=3, StringSize:=2)
        >
        Public Property AutoPOPolicy() As String

            Get
                Return Me.GetPropertyValue("AutoPOPolicy")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("AutoPOPolicy", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=4)
        >
        Public Property BMIDirStdCost() As Double

            Get
                Return Me.GetPropertyValue("BMIDirStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("BMIDirStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=5)
        >
        Public Property BMIFOvhStdCost() As Double

            Get
                Return Me.GetPropertyValue("BMIFOvhStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("BMIFOvhStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=6)
        >
        Public Property BMILastCost() As Double

            Get
                Return Me.GetPropertyValue("BMILastCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("BMILastCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=7)
        >
        Public Property BMIPDirStdCost() As Double

            Get
                Return Me.GetPropertyValue("BMIPDirStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("BMIPDirStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=8)
        >
        Public Property BMIPFOvhStdCost() As Double

            Get
                Return Me.GetPropertyValue("BMIPFOvhStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("BMIPFOvhStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=9)
        >
        Public Property BMIPStdCost() As Double

            Get
                Return Me.GetPropertyValue("BMIPStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("BMIPStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=10)
        >
        Public Property BMIPVOvhStdCost() As Double

            Get
                Return Me.GetPropertyValue("BMIPVOvhStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("BMIPVOvhStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=11)
        >
        Public Property BMIStdCost() As Double

            Get
                Return Me.GetPropertyValue("BMIStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("BMIStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=12)
        >
        Public Property BMIVOvhStdCost() As Double

            Get
                Return Me.GetPropertyValue("BMIVOvhStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("BMIVOvhStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=13, StringSize:=10)
        >
        Public Property BOLCode() As String

            Get
                Return Me.GetPropertyValue("BOLCode")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("BOLCode", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=14, StringSize:=10)
        >
        Public Property Buyer() As String

            Get
                Return Me.GetPropertyValue("Buyer")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Buyer", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=15, StringSize:=1)
        >
        Public Property ChkOrdQty() As String

            Get
                Return Me.GetPropertyValue("ChkOrdQty")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("ChkOrdQty", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=16, StringSize:=6)
        >
        Public Property ClassID() As String

            Get
                Return Me.GetPropertyValue("ClassID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("ClassID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=17, StringSize:=10)
        >
        Public Property COGSAcct() As String

            Get
                Return Me.GetPropertyValue("COGSAcct")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("COGSAcct", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=18, StringSize:=24)
        >
        Public Property COGSSub() As String

            Get
                Return Me.GetPropertyValue("COGSSub")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("COGSSub", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=19, StringSize:=20)
        >
        Public Property Color() As String

            Get
                Return Me.GetPropertyValue("Color")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Color", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=20, StringSize:=1)
        >
        Public Property CountStatus() As String

            Get
                Return Me.GetPropertyValue("CountStatus")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("CountStatus", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=21)
        >
        Public Property Crtd_DateTime() As Integer

            Get
                Return Me.GetPropertyValue("Crtd_DateTime")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("Crtd_DateTime", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=22, StringSize:=8)
        >
        Public Property Crtd_Prog() As String

            Get
                Return Me.GetPropertyValue("Crtd_Prog")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Crtd_Prog", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=23, StringSize:=10)
        >
        Public Property Crtd_User() As String

            Get
                Return Me.GetPropertyValue("Crtd_User")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Crtd_User", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=24)
        >
        Public Property CuryListPrice() As Double

            Get
                Return Me.GetPropertyValue("CuryListPrice")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryListPrice", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=25)
        >
        Public Property CuryMinPrice() As Double

            Get
                Return Me.GetPropertyValue("CuryMinPrice")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryMinPrice", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=26)
        >
        Public Property CustomFtr() As Short

            Get
                Return Me.GetPropertyValue("CustomFtr")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("CustomFtr", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=27, StringSize:=10)
        >
        Public Property CycleID() As String

            Get
                Return Me.GetPropertyValue("CycleID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("CycleID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=28, StringSize:=60)
        >
        Public Property Descr() As String

            Get
                Return Me.GetPropertyValue("Descr")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Descr", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=29, StringSize:=10)
        >
        Public Property DfltPickLoc() As String

            Get
                Return Me.GetPropertyValue("DfltPickLoc")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("DfltPickLoc", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=30, StringSize:=6)
        >
        Public Property DfltPOUnit() As String

            Get
                Return Me.GetPropertyValue("DfltPOUnit")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("DfltPOUnit", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=31, StringSize:=10)
        >
        Public Property DfltSalesAcct() As String

            Get
                Return Me.GetPropertyValue("DfltSalesAcct")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("DfltSalesAcct", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=32, StringSize:=24)
        >
        Public Property DfltSalesSub() As String

            Get
                Return Me.GetPropertyValue("DfltSalesSub")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("DfltSalesSub", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=33, StringSize:=10)
        >
        Public Property DfltShpnotInvAcct() As String

            Get
                Return Me.GetPropertyValue("DfltShpnotInvAcct")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("DfltShpnotInvAcct", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=34, StringSize:=24)
        >
        Public Property DfltShpnotInvSub() As String

            Get
                Return Me.GetPropertyValue("DfltShpnotInvSub")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("DfltShpnotInvSub", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=35, StringSize:=10)
        >
        Public Property DfltSite() As String

            Get
                Return Me.GetPropertyValue("DfltSite")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("DfltSite", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=36, StringSize:=6)
        >
        Public Property DfltSOUnit() As String

            Get
                Return Me.GetPropertyValue("DfltSOUnit")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("DfltSOUnit", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=37, StringSize:=10)
        >
        Public Property DfltWhseLoc() As String

            Get
                Return Me.GetPropertyValue("DfltWhseLoc")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("DfltWhseLoc", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=38)
        >
        Public Property DirStdCost() As Double

            Get
                Return Me.GetPropertyValue("DirStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("DirStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=39, StringSize:=10)
        >
        Public Property DiscAcct() As String

            Get
                Return Me.GetPropertyValue("DiscAcct")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("DiscAcct", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=40, StringSize:=1)
        >
        Public Property DiscPrc() As String

            Get
                Return Me.GetPropertyValue("DiscPrc")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("DiscPrc", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=41, StringSize:=31)
        >
        Public Property DiscSub() As String

            Get
                Return Me.GetPropertyValue("DiscSub")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("DiscSub", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=42)
        >
        Public Property EOQ() As Double

            Get
                Return Me.GetPropertyValue("EOQ")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("EOQ", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=43)
        >
        Public Property ExplInvoice() As Short

            Get
                Return Me.GetPropertyValue("ExplInvoice")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("ExplInvoice", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=44)
        >
        Public Property ExplOrder() As Short

            Get
                Return Me.GetPropertyValue("ExplOrder")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("ExplOrder", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=45)
        >
        Public Property ExplPackSlip() As Short

            Get
                Return Me.GetPropertyValue("ExplPackSlip")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("ExplPackSlip", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=46)
        >
        Public Property ExplPickList() As Short

            Get
                Return Me.GetPropertyValue("ExplPickList")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("ExplPickList", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=47)
        >
        Public Property ExplShipping() As Short

            Get
                Return Me.GetPropertyValue("ExplShipping")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("ExplShipping", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=48)
        >
        Public Property FOvhStdCost() As Double

            Get
                Return Me.GetPropertyValue("FOvhStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("FOvhStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=49, StringSize:=10)
        >
        Public Property FrtAcct() As String

            Get
                Return Me.GetPropertyValue("FrtAcct")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("FrtAcct", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=50, StringSize:=24)
        >
        Public Property FrtSub() As String

            Get
                Return Me.GetPropertyValue("FrtSub")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("FrtSub", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=51, StringSize:=4)
        >
        Public Property GLClassID() As String

            Get
                Return Me.GetPropertyValue("GLClassID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("GLClassID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=52, StringSize:=10)
        >
        Public Property InvtAcct() As String

            Get
                Return Me.GetPropertyValue("InvtAcct")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("InvtAcct", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=53, StringSize:=30)
        >
        Public Property InvtID() As String

            Get
                Return Me.GetPropertyValue("InvtID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("InvtID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=54, StringSize:=24)
        >
        Public Property InvtSub() As String

            Get
                Return Me.GetPropertyValue("InvtSub")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("InvtSub", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=55, StringSize:=1)
        >
        Public Property InvtType() As String

            Get
                Return Me.GetPropertyValue("InvtType")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("InvtType", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=56, StringSize:=1)
        >
        Public Property IRCalcPolicy() As String

            Get
                Return Me.GetPropertyValue("IRCalcPolicy")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("IRCalcPolicy", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=57)
        >
        Public Property IRDaysSupply() As Double

            Get
                Return Me.GetPropertyValue("IRDaysSupply")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("IRDaysSupply", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=58, StringSize:=10)
        >
        Public Property IRDemandID() As String

            Get
                Return Me.GetPropertyValue("IRDemandID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("IRDemandID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=59)
        >
        Public Property IRFutureDate() As Integer

            Get
                Return Me.GetPropertyValue("IRFutureDate")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("IRFutureDate", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=60, StringSize:=1)
        >
        Public Property IRFuturePolicy() As String

            Get
                Return Me.GetPropertyValue("IRFuturePolicy")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("IRFuturePolicy", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=61, StringSize:=10)
        >
        Public Property IRLeadTimeID() As String

            Get
                Return Me.GetPropertyValue("IRLeadTimeID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("IRLeadTimeID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=62)
        >
        Public Property IRLinePtQty() As Double

            Get
                Return Me.GetPropertyValue("IRLinePtQty")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("IRLinePtQty", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=63)
        >
        Public Property IRMinOnHand() As Double

            Get
                Return Me.GetPropertyValue("IRMinOnHand")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("IRMinOnHand", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=64, StringSize:=30)
        >
        Public Property IRModelInvtID() As String

            Get
                Return Me.GetPropertyValue("IRModelInvtID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("IRModelInvtID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=65)
        >
        Public Property IRRCycDays() As Short

            Get
                Return Me.GetPropertyValue("IRRCycDays")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("IRRCycDays", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=66)
        >
        Public Property IRSeasonEndDay() As Short

            Get
                Return Me.GetPropertyValue("IRSeasonEndDay")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("IRSeasonEndDay", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=67)
        >
        Public Property IRSeasonEndMon() As Short

            Get
                Return Me.GetPropertyValue("IRSeasonEndMon")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("IRSeasonEndMon", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=68)
        >
        Public Property IRSeasonStrtDay() As Short

            Get
                Return Me.GetPropertyValue("IRSeasonStrtDay")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("IRSeasonStrtDay", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=69)
        >
        Public Property IRSeasonStrtMon() As Short

            Get
                Return Me.GetPropertyValue("IRSeasonStrtMon")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("IRSeasonStrtMon", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=70)
        >
        Public Property IRServiceLevel() As Double

            Get
                Return Me.GetPropertyValue("IRServiceLevel")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("IRServiceLevel", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=71)
        >
        Public Property IRSftyStkDays() As Double

            Get
                Return Me.GetPropertyValue("IRSftyStkDays")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("IRSftyStkDays", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=72)
        >
        Public Property IRSftyStkPct() As Double

            Get
                Return Me.GetPropertyValue("IRSftyStkPct")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("IRSftyStkPct", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=73, StringSize:=1)
        >
        Public Property IRSftyStkPolicy() As String

            Get
                Return Me.GetPropertyValue("IRSftyStkPolicy")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("IRSftyStkPolicy", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=74, StringSize:=1)
        >
        Public Property IRSourceCode() As String

            Get
                Return Me.GetPropertyValue("IRSourceCode")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("IRSourceCode", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=75, StringSize:=1)
        >
        Public Property IRTargetOrdMethod() As String

            Get
                Return Me.GetPropertyValue("IRTargetOrdMethod")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("IRTargetOrdMethod", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=76)
        >
        Public Property IRTargetOrdReq() As Double

            Get
                Return Me.GetPropertyValue("IRTargetOrdReq")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("IRTargetOrdReq", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=77, StringSize:=10)
        >
        Public Property IRTransferSiteID() As String

            Get
                Return Me.GetPropertyValue("IRTransferSiteID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("IRTransferSiteID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=78, StringSize:=10)
        >
        Public Property ItemCommClassID() As String

            Get
                Return Me.GetPropertyValue("ItemCommClassID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("ItemCommClassID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=79)
        >
        Public Property Kit() As Short

            Get
                Return Me.GetPropertyValue("Kit")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("Kit", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=80)
        >
        Public Property LastBookQty() As Double

            Get
                Return Me.GetPropertyValue("LastBookQty")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("LastBookQty", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=81)
        >
        Public Property LastCost() As Double

            Get
                Return Me.GetPropertyValue("LastCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("LastCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=82)
        >
        Public Property LastCountDate() As Integer

            Get
                Return Me.GetPropertyValue("LastCountDate")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("LastCountDate", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=83, StringSize:=10)
        >
        Public Property LastSiteID() As String

            Get
                Return Me.GetPropertyValue("LastSiteID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("LastSiteID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=84)
        >
        Public Property LastStdCost() As Double

            Get
                Return Me.GetPropertyValue("LastStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("LastStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=85)
        >
        Public Property LastVarAmt() As Double

            Get
                Return Me.GetPropertyValue("LastVarAmt")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("LastVarAmt", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=86)
        >
        Public Property LastVarPct() As Double

            Get
                Return Me.GetPropertyValue("LastVarPct")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("LastVarPct", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=87)
        >
        Public Property LastVarQty() As Double

            Get
                Return Me.GetPropertyValue("LastVarQty")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("LastVarQty", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=88, StringSize:=10)
        >
        Public Property LCVarianceAcct() As String

            Get
                Return Me.GetPropertyValue("LCVarianceAcct")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("LCVarianceAcct", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=89, StringSize:=24)
        >
        Public Property LCVarianceSub() As String

            Get
                Return Me.GetPropertyValue("LCVarianceSub")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("LCVarianceSub", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=90)
        >
        Public Property LeadTime() As Double

            Get
                Return Me.GetPropertyValue("LeadTime")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("LeadTime", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=91)
        >
        Public Property LinkSpecId() As Short

            Get
                Return Me.GetPropertyValue("LinkSpecId")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("LinkSpecId", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=92)
        >
        Public Property LotSerFxdLen() As Short

            Get
                Return Me.GetPropertyValue("LotSerFxdLen")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("LotSerFxdLen", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=93, StringSize:=1)
        >
        Public Property LotSerFxdTyp() As String

            Get
                Return Me.GetPropertyValue("LotSerFxdTyp")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("LotSerFxdTyp", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=94, StringSize:=12)
        >
        Public Property LotSerFxdVal() As String

            Get
                Return Me.GetPropertyValue("LotSerFxdVal")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("LotSerFxdVal", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=95, StringSize:=1)
        >
        Public Property LotSerIssMthd() As String

            Get
                Return Me.GetPropertyValue("LotSerIssMthd")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("LotSerIssMthd", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=96)
        >
        Public Property LotSerNumLen() As Short

            Get
                Return Me.GetPropertyValue("LotSerNumLen")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("LotSerNumLen", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=97, StringSize:=25)
        >
        Public Property LotSerNumVal() As String

            Get
                Return Me.GetPropertyValue("LotSerNumVal")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("LotSerNumVal", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=98, StringSize:=2)
        >
        Public Property LotSerTrack() As String

            Get
                Return Me.GetPropertyValue("LotSerTrack")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("LotSerTrack", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=99)
        >
        Public Property LUpd_DateTime() As Integer

            Get
                Return Me.GetPropertyValue("LUpd_DateTime")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("LUpd_DateTime", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=100, StringSize:=8)
        >
        Public Property LUpd_Prog() As String

            Get
                Return Me.GetPropertyValue("LUpd_Prog")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("LUpd_Prog", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=101, StringSize:=10)
        >
        Public Property LUpd_User() As String

            Get
                Return Me.GetPropertyValue("LUpd_User")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("LUpd_User", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=102, StringSize:=10)
        >
        Public Property MaterialType() As String

            Get
                Return Me.GetPropertyValue("MaterialType")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("MaterialType", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=103)
        >
        Public Property MaxOnHand() As Double

            Get
                Return Me.GetPropertyValue("MaxOnHand")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("MaxOnHand", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=104, StringSize:=10)
        >
        Public Property MfgClassID() As String

            Get
                Return Me.GetPropertyValue("MfgClassID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("MfgClassID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=105)
        >
        Public Property MfgLeadTime() As Double

            Get
                Return Me.GetPropertyValue("MfgLeadTime")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("MfgLeadTime", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=106)
        >
        Public Property MinGrossProfit() As Double

            Get
                Return Me.GetPropertyValue("MinGrossProfit")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("MinGrossProfit", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=107, StringSize:=10)
        >
        Public Property MoveClass() As String

            Get
                Return Me.GetPropertyValue("MoveClass")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("MoveClass", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=108, StringSize:=24)
        >
        Public Property MSDS() As String

            Get
                Return Me.GetPropertyValue("MSDS")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("MSDS", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=109)
        >
        Public Property NoteID() As Integer

            Get
                Return Me.GetPropertyValue("NoteID")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("NoteID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=110, StringSize:=6)
        >
        Public Property Pack() As String

            Get
                Return Me.GetPropertyValue("Pack")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Pack", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=111)
        >
        Public Property PDirStdCost() As Double

            Get
                Return Me.GetPropertyValue("PDirStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("PDirStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=112, StringSize:=6)
        >
        Public Property PerNbr() As String

            Get
                Return Me.GetPropertyValue("PerNbr")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("PerNbr", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=113)
        >
        Public Property PFOvhStdCost() As Double

            Get
                Return Me.GetPropertyValue("PFOvhStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("PFOvhStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=114, StringSize:=10)
        >
        Public Property PPVAcct() As String

            Get
                Return Me.GetPropertyValue("PPVAcct")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("PPVAcct", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=115, StringSize:=24)
        >
        Public Property PPVSub() As String

            Get
                Return Me.GetPropertyValue("PPVSub")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("PPVSub", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=116, StringSize:=6)
        >
        Public Property PriceClassID() As String

            Get
                Return Me.GetPropertyValue("PriceClassID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("PriceClassID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=117, StringSize:=10)
        >
        Public Property ProdMgrID() As String

            Get
                Return Me.GetPropertyValue("ProdMgrID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("ProdMgrID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=118, StringSize:=6)
        >
        Public Property ProductionUnit() As String

            Get
                Return Me.GetPropertyValue("ProductionUnit")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("ProductionUnit", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=119)
        >
        Public Property PStdCost() As Double

            Get
                Return Me.GetPropertyValue("PStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("PStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=120)
        >
        Public Property PStdCostDate() As Integer

            Get
                Return Me.GetPropertyValue("PStdCostDate")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("PStdCostDate", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=121)
        >
        Public Property PVOvhStdCost() As Double

            Get
                Return Me.GetPropertyValue("PVOvhStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("PVOvhStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=122)
        >
        Public Property ReordPt() As Double

            Get
                Return Me.GetPropertyValue("ReordPt")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("ReordPt", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=123)
        >
        Public Property ReOrdPtCalc() As Double

            Get
                Return Me.GetPropertyValue("ReOrdPtCalc")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("ReOrdPtCalc", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=124)
        >
        Public Property ReordQty() As Double

            Get
                Return Me.GetPropertyValue("ReordQty")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("ReordQty", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=125)
        >
        Public Property ReOrdQtyCalc() As Double

            Get
                Return Me.GetPropertyValue("ReOrdQtyCalc")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("ReOrdQtyCalc", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=126, StringSize:=1)
        >
        Public Property ReplMthd() As String

            Get
                Return Me.GetPropertyValue("ReplMthd")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("ReplMthd", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=127)
        >
        Public Property RollupCost() As Short

            Get
                Return Me.GetPropertyValue("RollupCost")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("RollupCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=128)
        >
        Public Property RollupPrice() As Short

            Get
                Return Me.GetPropertyValue("RollupPrice")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("RollupPrice", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=129)
        >
        Public Property RvsdPrc() As Short

            Get
                Return Me.GetPropertyValue("RvsdPrc")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("RvsdPrc", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=130, StringSize:=30)
        >
        Public Property S4Future01() As String

            Get
                Return Me.GetPropertyValue("S4Future01")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("S4Future01", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=131, StringSize:=30)
        >
        Public Property S4Future02() As String

            Get
                Return Me.GetPropertyValue("S4Future02")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("S4Future02", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=132)
        >
        Public Property S4Future03() As Double

            Get
                Return Me.GetPropertyValue("S4Future03")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("S4Future03", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=133)
        >
        Public Property S4Future04() As Double

            Get
                Return Me.GetPropertyValue("S4Future04")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("S4Future04", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=134)
        >
        Public Property S4Future05() As Double

            Get
                Return Me.GetPropertyValue("S4Future05")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("S4Future05", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=135)
        >
        Public Property S4Future06() As Double

            Get
                Return Me.GetPropertyValue("S4Future06")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("S4Future06", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=136)
        >
        Public Property S4Future07() As Integer

            Get
                Return Me.GetPropertyValue("S4Future07")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("S4Future07", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=137)
        >
        Public Property S4Future08() As Integer

            Get
                Return Me.GetPropertyValue("S4Future08")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("S4Future08", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=138)
        >
        Public Property S4Future09() As Integer

            Get
                Return Me.GetPropertyValue("S4Future09")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("S4Future09", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=139)
        >
        Public Property S4Future10() As Integer

            Get
                Return Me.GetPropertyValue("S4Future10")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("S4Future10", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=140, StringSize:=10)
        >
        Public Property S4Future11() As String

            Get
                Return Me.GetPropertyValue("S4Future11")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("S4Future11", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=141, StringSize:=10)
        >
        Public Property S4Future12() As String

            Get
                Return Me.GetPropertyValue("S4Future12")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("S4Future12", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=142, StringSize:=10)
        >
        Public Property S4Future13() As String

            Get
                Return Me.GetPropertyValue("S4Future13")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("S4Future13", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=143)
        >
        Public Property SafetyStk() As Double

            Get
                Return Me.GetPropertyValue("SafetyStk")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("SafetyStk", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=144)
        >
        Public Property SafetyStkCalc() As Double

            Get
                Return Me.GetPropertyValue("SafetyStkCalc")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("SafetyStkCalc", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=145)
        >
        Public Property Selected() As Short

            Get
                Return Me.GetPropertyValue("Selected")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("Selected", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=146, StringSize:=1)
        >
        Public Property SerAssign() As String

            Get
                Return Me.GetPropertyValue("SerAssign")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("SerAssign", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=147)
        >
        Public Property Service() As Short

            Get
                Return Me.GetPropertyValue("Service")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("Service", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=148)
        >
        Public Property ShelfLife() As Short

            Get
                Return Me.GetPropertyValue("ShelfLife")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("ShelfLife", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=149, StringSize:=10)
        >
        Public Property Size() As String

            Get
                Return Me.GetPropertyValue("Size")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Size", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=150, StringSize:=1)
        >
        Public Property Source() As String

            Get
                Return Me.GetPropertyValue("Source")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Source", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=151, StringSize:=1)
        >
        Public Property Status() As String

            Get
                Return Me.GetPropertyValue("Status")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Status", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=152)
        >
        Public Property StdCost() As Double

            Get
                Return Me.GetPropertyValue("StdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("StdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=153)
        >
        Public Property StdCostDate() As Integer

            Get
                Return Me.GetPropertyValue("StdCostDate")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("StdCostDate", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=154)
        >
        Public Property StkBasePrc() As Double

            Get
                Return Me.GetPropertyValue("StkBasePrc")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("StkBasePrc", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=155)
        >
        Public Property StkItem() As Short

            Get
                Return Me.GetPropertyValue("StkItem")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("StkItem", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=156)
        >
        Public Property StkRvsdPrc() As Double

            Get
                Return Me.GetPropertyValue("StkRvsdPrc")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("StkRvsdPrc", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=157)
        >
        Public Property StkTaxBasisPrc() As Double

            Get
                Return Me.GetPropertyValue("StkTaxBasisPrc")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("StkTaxBasisPrc", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=158, StringSize:=6)
        >
        Public Property StkUnit() As String

            Get
                Return Me.GetPropertyValue("StkUnit")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("StkUnit", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=159)
        >
        Public Property StkVol() As Double

            Get
                Return Me.GetPropertyValue("StkVol")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("StkVol", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=160)
        >
        Public Property StkWt() As Double

            Get
                Return Me.GetPropertyValue("StkWt")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("StkWt", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=161, StringSize:=6)
        >
        Public Property StkWtUnit() As String

            Get
                Return Me.GetPropertyValue("StkWtUnit")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("StkWtUnit", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=162, StringSize:=10)
        >
        Public Property Style() As String

            Get
                Return Me.GetPropertyValue("Style")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Style", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=163, StringSize:=15)
        >
        Public Property Supplr1() As String

            Get
                Return Me.GetPropertyValue("Supplr1")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Supplr1", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=164, StringSize:=15)
        >
        Public Property Supplr2() As String

            Get
                Return Me.GetPropertyValue("Supplr2")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Supplr2", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=165, StringSize:=20)
        >
        Public Property SupplrItem1() As String

            Get
                Return Me.GetPropertyValue("SupplrItem1")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("SupplrItem1", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=166, StringSize:=20)
        >
        Public Property SupplrItem2() As String

            Get
                Return Me.GetPropertyValue("SupplrItem2")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("SupplrItem2", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=167, StringSize:=32)
        >
        Public Property TaskID() As String

            Get
                Return Me.GetPropertyValue("TaskID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("TaskID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=168, StringSize:=10)
        >
        Public Property TaxCat() As String

            Get
                Return Me.GetPropertyValue("TaxCat")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("TaxCat", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=169, StringSize:=2)
        >
        Public Property TranStatusCode() As String

            Get
                Return Me.GetPropertyValue("TranStatusCode")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("TranStatusCode", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=170)
        >
        Public Property Turns() As Double

            Get
                Return Me.GetPropertyValue("Turns")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("Turns", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=171, StringSize:=30)
        >
        Public Property UPCCode() As String

            Get
                Return Me.GetPropertyValue("UPCCode")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("UPCCode", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=172)
        >
        Public Property UsageRate() As Double

            Get
                Return Me.GetPropertyValue("UsageRate")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("UsageRate", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=173, StringSize:=30)
        >
        Public Property User1() As String

            Get
                Return Me.GetPropertyValue("User1")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User1", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=174, StringSize:=30)
        >
        Public Property User2() As String

            Get
                Return Me.GetPropertyValue("User2")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User2", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=175)
        >
        Public Property User3() As Double

            Get
                Return Me.GetPropertyValue("User3")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("User3", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=176)
        >
        Public Property User4() As Double

            Get
                Return Me.GetPropertyValue("User4")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("User4", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=177, StringSize:=10)
        >
        Public Property User5() As String

            Get
                Return Me.GetPropertyValue("User5")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User5", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=178, StringSize:=10)
        >
        Public Property User6() As String

            Get
                Return Me.GetPropertyValue("User6")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User6", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=179)
        >
        Public Property User7() As Integer

            Get
                Return Me.GetPropertyValue("User7")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("User7", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=180)
        >
        Public Property User8() As Integer

            Get
                Return Me.GetPropertyValue("User8")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("User8", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=181, StringSize:=1)
        >
        Public Property ValMthd() As String

            Get
                Return Me.GetPropertyValue("ValMthd")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("ValMthd", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=182)
        >
        Public Property VOvhStdCost() As Double

            Get
                Return Me.GetPropertyValue("VOvhStdCost")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("VOvhStdCost", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=183)
        >
        Public Property WarrantyDays() As Short

            Get
                Return Me.GetPropertyValue("WarrantyDays")
            End Get

            Set(ByVal setval As Short)
                Me.SetPropertyValue("WarrantyDays", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=184)
        >
        Public Property YTDUsage() As Double

            Get
                Return Me.GetPropertyValue("YTDUsage")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("YTDUsage", setval)
            End Set

        End Property
    End Class
    Public bInventory As Inventory = New Inventory, nInventory As Inventory = New Inventory
    Public Csr_Inventory As Integer, Mem_Inventory As Integer
End Module
