using CartFlow.Common;
using CartFlow.Dtos.Coupons;
using CartFlow.Models;
using CartFlow.Repositories;
using CartFlow.UnitOfWorks;

namespace CartFlow.Services;

public sealed class CouponService(CouponRepository couponRepository, UnitOfWork unitOfWork)
{
    public async Task<Result<Guid>> CreateAsync(CreateCouponRequest request, CancellationToken cancellationToken)
    {
        var isExist = await couponRepository.AnyAsync(c => c.Code == request.Code, cancellationToken);
        if (isExist)
            return Result<Guid>.Conflict("Coupon code already exists");
        
        var coupon = new Coupon()
        {
            Code = request.Code,
            DiscountAmount = request.DiscountAmount,
            IsPercentage = request.IsPercentage,
            ExpiresAt = request.ExpiresAt
        };
        
        await couponRepository.AddAsync(coupon, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<Guid>.Created(coupon.Id);
    }
    
    public async Task<Result<CouponDto?>> GetByCodeAsync(string code, CancellationToken cancellationToken)
    {
        var coupon = await couponRepository.GetByCodeAsync(code, cancellationToken);
        if (coupon is null)
            return Result<CouponDto?>.NotFound("Coupon not found");

        var result = new CouponDto(
            coupon.Id,
            coupon.Code,
            coupon.DiscountAmount,
            coupon.IsPercentage,
            coupon.ExpiresAt);
        
        return Result<CouponDto?>.Success(result); 
    }
}