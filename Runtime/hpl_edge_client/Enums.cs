namespace HplEdgeClient.Enums
{
    public enum SourceKind
    {
        Assembled,
        Nft,
        Cnft,
        TokenExtensions,
        MplCoreAsset
    }

    public enum CivicGateway
    {
        LivenessPass,
        UniquenessPass,
        IdVerificationPass
    }

    public enum BadgesCondition
    {
        Public
    }

    public enum HiveControlPermissionInput
    {
        ManageCriterias,
        ManageServices,
        ManageIndexing,
        ManageProfiles
    }

    public enum AssetAssemblerPermissionInput
    {
        ManageAssembler,
        UpdateBlock,
        UpdateBlockDefinition,
        UpdateNFT,
        InitialArtGeneration
    }

    public enum AssetManagerPermissionInput
    {
        ManageAssets
    }

    public enum CurrencyManagerPermissionInput
    {
        ManageCurrencies,
        MintCurrencies,
        ManageCurrencyStatus
    }

    public enum NectarStakingPermissionInput
    {
        ManageStakingPool,
        WithdrawStakingPoolRewards
    }

    public enum NectarMissionsPermissionInput
    {
        ManageMissionPool,
        WithdrawMissionPoolRewards
    }

    public enum BuzzGuildPermissionInput
    {
        ManageGuildKit
    }

    public enum LockTypeEnum
    {
        Freeze,
        Custoday
    }

    public enum RewardKind
    {
        Xp,
        Resource
    }

    public enum ResourceStorageEnum
    {
        AccountState,
        LedgerState
    }

}

